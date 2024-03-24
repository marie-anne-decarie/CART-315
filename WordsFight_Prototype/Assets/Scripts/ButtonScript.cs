using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text speechBubble;
    
    // Start is called before the first frame update
    void Start()
    {
        speechBubble.text = "You"; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddWord()
    {
        string thisWord = this.gameObject.GetComponentInChildren<Text>().text;
        speechBubble.text += (" " + thisWord);
    }

    public void MysteryWord()
    {

    }
}
