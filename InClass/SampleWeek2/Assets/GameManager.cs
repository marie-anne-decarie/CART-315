using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int points;
    public Text score, livesLeft;

    // Singleton :3
    public static GameManager S;

    // Awake is called before start in the very beginning
    void Awake()
    {
        S = this;
        
    }

    private void Start()
    {
        lives = 4;
        livesLeft.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoseLife()
    {
        if (lives == 1)
        {
            SceneManager.LoadScene("Breakout");
        }
        else
        {
            lives -= 1;
        livesLeft.text = lives.ToString();
        }
    }

    public void AddPoints(int numPoints)
    {
        points += numPoints;
        score.text=points.ToString();
    }
}
