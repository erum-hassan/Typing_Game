using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using menuScript;


public class MenuManager : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject buttonTemplate;
    public GameObject scrollViewContent;

    public InputField inputuser;
    
    [SerializeField]
    private List<string> langList;

     // Add Language Portion
     
     
    // Start is called before the first frame update
    void Start()
    {
     GetData();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
            mainPanel.SetActive(false);
    }
    public void QuitGame(){
        Application.Quit();
    }

    public void GetData(){
       langList = PlayerPrefsExtra.GetList<string>("listlang",new List<string>());
      
       foreach (string item   in langList)
       {
           GameObject btnLang = (GameObject)Instantiate(buttonTemplate);
       btnLang.GetComponentInChildren<Text>().text = item;
     
      btnLang.transform.SetParent(scrollViewContent.transform,false) ;
        
     
       }
    
    }

    public void AddLanguge(){

     
       langList.Add(inputuser.text);
       
       List<Word> newList = new List<Word>();
       PlayerPrefsExtra.SetList(inputuser.text.ToString(),newList);
    

      PlayerPrefsExtra.SetList("listlang",langList);
      updateList();
      GetData();
     
    }

    public void updateList(){
       foreach (RectTransform child in scrollViewContent.transform)
    { 
    Destroy(child.gameObject);             
    }  
 }

 
//  public void getName(){
//    string name =GameObject.Find(EventSystem.current.currentSelectedGameObject.name).GetComponent<Button>().GetComponentInChildren<Text>().text; 
   
//     Debug.Log(name);
//  }
    


   
}
