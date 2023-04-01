using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace GameScript{
    public class WordDisplay : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float fallSpeed = 1f;
    private WordManager wordManager;


 public void Start()
    {
         wordManager = GameObject.Find("Manager").GetComponent<WordManager>();
       
    }
    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveWord()
    {
        if(gameObject != null){
            Destroy(gameObject);
        }
    }
     public void RemoveLetter()
    {
       
        text.color = Color.red;
    }
   
    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
         if(transform.position.y < -5f)
        {

            wordManager.failedAttempt(text.text);
           
          
        }
     
    }
}
}
