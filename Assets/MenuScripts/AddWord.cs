using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using menuScript;

public class AddWord : MonoBehaviour
{
    public GameObject  addword;
    public Button addwordbtn;
    public InputField Word;
    public InputField Translation;
    public GameObject WordTemplate;
    public  GameObject scrollViewContent;
    public GameObject wordListPanel ;


    private string stringData;
   
    public List<Word> words;
  public void Start(){
    stringData=PlayerPrefs.GetString("currentLanguage");
   words = PlayerPrefsExtra.GetList<Word>(stringData, new List<Word>());
     addwordbtn.onClick.AddListener(AddData);
     GetListWords();
   
  }

    public void AddDataPanel(){
      wordListPanel.gameObject.SetActive(false);
        addword.gameObject.SetActive(true);  
    }
    public void AddData(){

         Word word = new Word(Word.text,Translation.text);
        words.Add(word);
        saveList();
        updateList();
        GetListWords();
        wordListPanel.gameObject.SetActive(true);
        addword.gameObject.SetActive(false);  
    }


    public void GetListWords(){
      
      foreach(Word item in words){
        GameObject wordInstance = (GameObject)Instantiate(WordTemplate);
      wordInstance.GetComponentInChildren<Text>().text = item.word;
      wordInstance.transform.SetParent(scrollViewContent.transform,false);
      }
    }
     public void updateList(){
       foreach (RectTransform child in scrollViewContent.transform)
    { 
    Destroy(child.gameObject);             
    } 


    
}

public void PlayGameButton(){
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
}
public void saveList()
    {
        PlayerPrefsExtra.SetList(stringData,words);
    }
}
