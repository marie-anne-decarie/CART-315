using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text speechBubble;

    public NewWordScript nws;
    
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

    public void SpecialButton()
    {
        int specialNumber = Random.Range(0, nws.special.Count);
        string specialPhrase = nws.special[specialNumber];
        speechBubble.text = specialPhrase;
        nws.specialAttack = true;
    }

}
