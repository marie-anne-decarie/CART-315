using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewWordScript : MonoBehaviour
{
    private TextAsset nouns_asset;
    private TextAsset adj_asset;
    public List<string> nouns = new List<string>();
    public List<string> adj = new List<string>();

    public GameObject canvas;
    public GameObject[] greenButtons;
    public GameObject[] purpleButtons;
    private Text[] greenWords;

    
    // Start is called before the first frame update
    void Start()
    {
        LoadWordbank();
        DisplayGreenWords();
        DisplayPurpleWords();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayGreenWords()
    {
        foreach(GameObject g in greenButtons)
        {
            Text word = g.GetComponentInChildren<Text>();
            int r = Random.Range(0, nouns.Count);
            word.text = nouns[r];
        }
    }
    void DisplayPurpleWords()
    {
        foreach (GameObject g in purpleButtons)
        {
            Text word = g.GetComponentInChildren<Text>();
            int r = Random.Range(0, adj.Count);
            word.text = adj[r];
        }
    }

    void LoadWordbank()
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
    }

}
