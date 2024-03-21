using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public List<WordButton> wordBank = new List<WordButton>();
    private List<WordButton> wordsOnScreen = new List<WordButton>();
    public Transform[] wordSlots;
    public bool[] availableWordSlots;

    public float timePassed = 0f;
    bool playerOneTurn = true;
    private int playerTurn;


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
            ClearWords();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("Tests");
        }
    }

    public void DisplayWords()
    {
        if(wordBank.Count>=1)
        {         
                for(int i =0; i<availableWordSlots.Length; i++)
                {
                if(availableWordSlots[i])
                    {
                    WordButton randWord = wordBank[Random.Range(0, wordBank.Count)];               
                    randWord.gameObject.SetActive(true);
                    randWord.transform.position = wordSlots[i].transform.position;
                    //availableWordSlots[i] = false;
                    wordBank.Remove(randWord);
                    wordsOnScreen.Add(randWord);
                    }

                }                                     
           
        }
        
    }

     public void ClearWords()
    {
        foreach(WordButton word in wordsOnScreen)
        {
            if (word.gameObject.activeSelf == true)
                word.gameObject.SetActive(false);

        }

        wordsOnScreen.Clear();
    }


}
