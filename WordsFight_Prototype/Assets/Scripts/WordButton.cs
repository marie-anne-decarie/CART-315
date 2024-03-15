using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordButton : MonoBehaviour
{
    public Text speechBubble;
    public string thisWord;

    [Header("Score")]
    public Text scoreText;
    public Text attackScore;
    public Text multiplier;
    public int tempScore; // the attack score before multiplier
    public int wordValue; // how many points is that word worth
    public int scoreMultiplier;
    public int totalAttackScore; // the final score with multiplier

    // Start is called before the first frame update
    void Start()
    {
        speechBubble.text = null;
        scoreText.text = "Final score ";
        attackScore.text = "Attack score ";
        multiplier.text = "Multiplier ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddWord()
    {
        //speechBubble.text = "Hello World";
        speechBubble.text += (" " + thisWord);
        Debug.Log("The bubble says" + speechBubble.text);
    }

    public void AddPoints()
    {
        // The nouns score values are added together
        tempScore += wordValue;
        attackScore.text = "Attack Score "+tempScore.ToString();
    }

    public void Multiplier()
    {
        // The adjectives values are added together
        scoreMultiplier += wordValue;
        multiplier.text = "Multiplier "+scoreMultiplier.ToString();
    }

    public void CalculateScore()
    {
        // The nouns and adjectives scores are multiplied together
        totalAttackScore = tempScore * scoreMultiplier;
        scoreText.text = "Final Score "+totalAttackScore.ToString();

    }
}
