using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText, attackScoreText, multiplierText;
    public int score=0;
    public int multiplier=0;
    public int totalScore;
    
    [SerializeField] Button[] words;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score";
        foreach (Button btn in words)
        {
            Button choice = btn; // need to store in separate variable to have the right button in the lamda expression
            btn.onClick.AddListener(() => TaskOnClick(choice));
        }
    }

    void TaskOnClick(Button choice)
    {
        attackScoreText.text = "Attack score: " + score.ToString();
        multiplierText.text = "Multiplier: " + multiplier.ToString();
        
        if (choice.gameObject.tag == "GreenButton")
        {
            multiplier += 2;
            Debug.Log("Green");
        }
        if(choice.gameObject.tag=="PurpleButton")
        {
            score += 10;
            Debug.Log("Purple");
        }
    }
    public void CalculatePoints()
        {

        if(multiplier>0)
        {
            totalScore = score * multiplier;
        }
        else
        {
            totalScore = score;
        }

        scoreText.text = "Score: "+totalScore.ToString();
        }


}

