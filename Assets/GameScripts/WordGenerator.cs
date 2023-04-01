using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using menuScript;



public class WordGenerator : MonoBehaviour
{
    public static Word[] wordList;

    
    // Start is called before the first frame update
    void Start()
    {
        string current = PlayerPrefs.GetString("currentLanguage");
        List<Word> list = PlayerPrefsExtra.GetList<Word>(current.ToString(), new List<Word>());
         wordList = list.ToArray();
        
        
        
    }

    public static Word GetRandomWord(){
        int randomIndex = Random.Range(0,wordList.Length);
        Word randomWord = wordList[randomIndex];
        
        return randomWord;
    }
}

