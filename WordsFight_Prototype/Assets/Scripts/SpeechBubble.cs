using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechBubble : MonoBehaviour
{
    public Text textInBubble;
    public Text chosenWord;
    public Button wordButton;
    
    
    // Start is called before the first frame update
    void Start()
    {
        textInBubble.text = null; 
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void DisplayText()
    {
        chosenWord = wordButton.GetComponentInChildren<Text>();
        textInBubble.text += " " + chosenWord.text;
    }
}
