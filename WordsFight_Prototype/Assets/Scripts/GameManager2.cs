using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public List<GameObject> wordBank = new List<GameObject>();
    public Transform[] wordSlots;
    public bool[] availableWordSlots;


    // Start is called before the first frame update
    void Start()
    {
      DisplayWords();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Tests");
        }
    }

    public void DisplayWords()
    {
        if(wordBank.Count>=1)
        {
            foreach(Transform t in wordSlots)
            {           
                GameObject randWord = wordBank[Random.Range(0, wordBank.Count)];               
                randWord.gameObject.SetActive(true);
                randWord.transform.position = t.position;          
                wordBank.Remove(randWord);                                         
            }

        }
        
    }
}
