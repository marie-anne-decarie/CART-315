using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{
    public Text sentence;
    public NewWordScript nws;

    // Start is called before the first frame update
    void Start()
    {
        sentence.text = "It only took you " + nws.turnsCount.ToString() + " insults!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
