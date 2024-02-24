using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameManager S;

    private void Awake()
    {
        S = this;
    }


    public SceneManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(ScoreScript.targetHits==30)
        {
            ScoreScript.targetHits = 31;
            SceneManager.LoadScene("Level2");
            
        }

        if (ScoreScript.targetHits == 61)
        {
            ScoreScript.targetHits = 60;
            SceneManager.LoadScene("GameOver");

        }

        if(ScoreScript.lives<0)
        {
            ScoreScript.lives = 3;
            SceneManager.LoadScene("Dead");
        }

        




    }




   
   
}
