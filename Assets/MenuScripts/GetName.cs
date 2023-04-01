using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetName : MonoBehaviour, IPointerClickHandler
{

   public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
        Text  text = GetComponentInChildren<Text>();
        PlayerPrefs.SetString("currentLanguage",text.text);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        

    }
}
