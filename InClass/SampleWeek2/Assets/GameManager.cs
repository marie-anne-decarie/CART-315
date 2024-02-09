using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        livesLeft.text = "<3: " + lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoseLife()
    {
        lives -= 1;
        livesLeft.text = "<3: " + lives.ToString();
    }

    public void AddPoints(int numPoints)
    {
        points += numPoints;
        score.text=points.ToString();
    }
}
