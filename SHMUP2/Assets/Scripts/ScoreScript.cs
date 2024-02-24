using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public Text powerUp;
    public Text nextLevel;
    public Text livesLeft;
    static public int score;
    static public bool deservePowerUp;
    static public int targetHits=0;

    static public int lives = 3;
   
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Your score is " + score.ToString();
        nextLevel.text = null;
        livesLeft.text = lives.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score ==50 || (score%100==0 && score>0)) GivePowerUp();
       
        scoreText.text = "Your score is " + score.ToString();
        livesLeft.text = "Hearts: "+lives.ToString();

        if(deservePowerUp)
        {
            powerUp.text = "Press Z to power up!";

        }
        if (specialShooter.shot >= 3)
        {
             powerUp.text = null;
            deservePowerUp = false;

        }


       





    }

    void GivePowerUp()
    {
        deservePowerUp = true;
    }
}
