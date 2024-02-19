using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    static public int score;

    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Your score is " + score.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
            score += 1;
        scoreText.text = "Your score is " + score.ToString();
    }
}
