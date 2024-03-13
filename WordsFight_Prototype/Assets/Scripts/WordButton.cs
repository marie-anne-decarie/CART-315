using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordButton : MonoBehaviour
{
    public Text speechBubble;
    private Text chosenWord;
    
    // Start is called before the first frame update
    void Start()
    {
        speechBubble.text = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        chosenWord = this.GetComponentInChildren<Text>();
        speechBubble.text = " " + chosenWord.text;
    }
}
