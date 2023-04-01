using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScript{
    
[System.Serializable]
    public class Word 
    {
        public string word;
    public string translation;
    WordDisplay display;
    int random;
    private int typeIndex;

    public string check_word;
    public string check_translation;


 public Word(string _word,string _translation, WordDisplay _display)
   
 {
        word = _word;
        translation = _translation;
        display = _display;
        typeIndex =0;
        random = Random.Range(0, 10);
       
        if (random <= 5)
        {
            check_word = translation;
            check_translation = word;
            display.SetWord(check_word);
          
           
           
        }
        else if(random >= 5)
        {
            check_word = word;
            check_translation = translation;
            display.SetWord(check_word);
      
           
        }
        
    }

    public char GetNextLetter(){
        return check_translation[typeIndex];
    }

    public  void TypeLetter(){
        typeIndex++;
        display.RemoveLetter();
       

    }

    public bool WordTyped(){
        bool wordTyped = (typeIndex >= check_translation.Length);
        if(wordTyped){
                display.RemoveWord();
        }
        return wordTyped;
    }
    public void removeWord()
    {
        display.RemoveWord();
    }
    
    }
}

