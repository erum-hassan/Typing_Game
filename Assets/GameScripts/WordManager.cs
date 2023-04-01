using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameScript;

namespace GameScript
{
    public class WordManager : MonoBehaviour
{
    public List<Word> words;
    private bool hasActiveWord;
    private Word activeWord;
    public WordSpawner wordSpawner;
   
   
    // void  Start(){
    //     AddWord();
    // }
   

    public void AddWord(){
         menuScript.Word currentWord = WordGenerator.GetRandomWord();
         Debug.Log(currentWord.word + currentWord.translation);
          Word word = new Word(currentWord.word,currentWord.translation, wordSpawner.SpawnWord());
         words.Add(word);
    }
   public void TypeLetter(char letter){
       if(hasActiveWord){
                if(activeWord.GetNextLetter() == letter)
                {
                    activeWord.TypeLetter();
                }
                
       }
       else{
        foreach(Word word in words){
            if(word.GetNextLetter() == letter)
            {
                activeWord = word;
                hasActiveWord = true;
                word.TypeLetter();
                
                break;
            }
        }
       }

       if(hasActiveWord && activeWord.WordTyped()){
        hasActiveWord = false;
       
        words.Remove(activeWord);
       }
    }

     public void failedAttempt(string text)
    {
       foreach(Word word in words)
        {
            if (word.word ==text)
            {
                
                 word.removeWord();
                words.Remove(word);
                hasActiveWord = false;
                break;
            }
            

        //    if(word.check_translation == activeWord.check_translation)
        //     {
        //         hasActiveWord = false;
        //         word.removeWord();
        //         words.Remove(activeWord);
        //         break;
        //     }
       }  
    }


   }

}

