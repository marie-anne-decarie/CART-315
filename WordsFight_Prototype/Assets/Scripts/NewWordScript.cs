using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// This is basically my game manager script, but with a funky name:3 (not super clear i know rkjsfkghfk)

public class NewWordScript : MonoBehaviour
{
   // text assets
    private TextAsset nouns_asset;
    private TextAsset adj_asset;
    public TextAsset special_asset;

    // the lists to hold the different wordbanks (nouns, adjectives, and special phrases)
    public List<string> nouns = new List<string>();
    public List<string> adj = new List<string>(); 
    public List<string> special = new List<string>();

    public GameObject canvas;
    public GameObject[] greenButtons;
    public GameObject[] purpleButtons;

    public GameObject specialButton;
    public Opponent opp;

    [SerializeField] Button[] allWords;
    public Button[] wordButtons;


    // when true, allows the special attack to bypass the usual grammar rules
    public bool specialAttack;

    // Keeps track of the number of nouns and adj. in each insult
    public int nounCount = 0;
    public int adjCount = 0;
    public int swearCount = 0;
    public int punctuationCount = 0;
    // Counts the total number of words and punctuation signs in each insult
    public int totalWordCount;

    // Counts the number of turns it takes you to win
    public int turnsCount;

   // how many points is the attack worth
    public int attackWorth; // WIP

    // To access the content of the speech bubble
    public Text speechBubble; // WIP

    
    // Start is called before the first frame update
    void Start()
    {
        specialButton.SetActive(false);

        LoadWordbank();
        DisplayWords();
        
        foreach (Button btn in allWords)
        {
            Button wordChosen = btn; 
            btn.onClick.AddListener(() => TaskOnClick(wordChosen));
        }

    }

    // Update is called once per frame
    void Update()
    {        

        if (adjCount>=3)
        {
            DeactivateAdj();
        }
        if(nounCount>=1)
        {
            DeactivateNouns();
            DeactivateAdj();
        }
        if(opp.hitsStreak>=2)
        {
            specialButton.SetActive(true);
        }

    }

   
    void TaskOnClick(Button wordChosen) // This function keeps track of how many words have been selected each turn
    {
        totalWordCount++;
        
        if(wordChosen.gameObject.tag=="GreenButton") // green buttons = nouns
        {
            nounCount++;
        }
        if(wordChosen.gameObject.tag=="PurpleButton") // purple buttons = adjectives
        {
            adjCount++; 
        }
        if(wordChosen.gameObject.tag=="SwearWord") 
        {
            swearCount++;
        }
        if (wordChosen.gameObject.tag == "Punctuation")
        {
            punctuationCount++;
        }

    }

    public void DisplayWords() // displays random nouns and ajectives onto the green and purple buttons
    {

        foreach(GameObject g in greenButtons)
        {
            Text theNoun = g.GetComponentInChildren<Text>();
            int randNoun = Random.Range(0, nouns.Count);
            theNoun.text = nouns[randNoun];
            
            foreach (GameObject go in purpleButtons)
            {
                Text theAdj = go.GetComponentInChildren<Text>();
                int randAdj = Random.Range(0, adj.Count);
                theAdj.text = adj[randAdj];
            }
        }
    }

    void LoadWordbank() // takes the words from the nouns and adjectives lists and adds them to separate lists
    {
        nouns_asset = Resources.Load("nouns") as TextAsset;
        string[] nounsList = nouns_asset.text.Split('\n');
        for (int i = 0; i < nounsList.Length; i++)
        {
            nouns.Add(nounsList[i]);
        }
        adj_asset = Resources.Load("adjectives") as TextAsset;
        string[] adjList = adj_asset.text.Split('\n');
        for (int i = 0; i < adjList.Length; i++)
        {
            adj.Add(adjList[i]);
        }
        special_asset = Resources.Load("specials") as TextAsset;
        string[] specialList = special_asset.text.Split('\n');
        for (int i = 0; i < specialList.Length; i++)
        {
            special.Add(specialList[i]);
        }

    }

    public void ClearWords() // clears all the nouns and ajectives and replaces them with dot dot dot
    {

        foreach (GameObject g in greenButtons)
        {
            Text theNoun = g.GetComponentInChildren<Text>();
            theNoun.text = "...";

            foreach (GameObject go in purpleButtons)
            {
                Text theAdj = go.GetComponentInChildren<Text>();
                theAdj.text = "...";
            }
        }

    }

    public void ButtonsOff() //  deactivates ALL buttons  
    {
        foreach(Button b in wordButtons)
        {
            if(b.interactable==true)
            {
                b.interactable = false;
            }
        }

    }

    public void ButtonsOn() // reactivates ALL buttons 
    {
        foreach (Button b in wordButtons)
        {
            if (b.interactable == false)
            {
                b.interactable = true;
            }
        }

    }

    void DeactivateNouns()
    {
        foreach (Button noun in wordButtons)
        {
            if(noun.gameObject.tag=="GreenButton")
            {
                
                if(noun.interactable==true)
                {
                    noun.interactable = false;
                }

            }
        }
    }

    void DeactivateAdj()
    {
        foreach (Button adjective in wordButtons)
        {
            if (adjective.gameObject.tag == "PurpleButton")
            {
                if (adjective.interactable == true)
                {
                    adjective.interactable = false;
                }
            }
        }
    }

    public void DeactivateSpecialButton()
    {
        opp.hitsStreak = 0;
        specialButton.SetActive(false);
        DeactivateAdj();
        DeactivateNouns();
    }

    // WIP
    void CalculateAttackWorth()
    {
        if (adjCount == 0) attackWorth = 5;


    }


}
