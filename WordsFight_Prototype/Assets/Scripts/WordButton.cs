using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordButton : MonoBehaviour
{
    public Text speechBubble;
    public string thisWord;

    // Start is called before the first frame update
    void Start()
    {
        speechBubble.text = null;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddWord()
    {
        speechBubble.text += (" " + thisWord);
        //Debug.Log("The bubble says" + speechBubble.text);
    }


}
