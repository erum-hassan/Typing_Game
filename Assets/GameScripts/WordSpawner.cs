using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScript{
    public class WordSpawner : MonoBehaviour
{
     public GameObject wordPrefab;
    public Transform wordCanvas;
    public WordDisplay SpawnWord()
    {
        
        Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), .2f);
        GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();
        return wordDisplay;
    }
}

}