using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Opponent : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar hb;

    public NewWordScript nws;
 
    public Text reaction; // The opponent's reaction when you attack him

    public Animator anim;

    public GameObject opponentBubble;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        hb.SetMaxHealth(maxHealth);

        reaction.text = null;
        opponentBubble.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // ends the game if the opponent's health reaches 0
        if(currentHealth<=0) 
            {
                currentHealth = 1;
                SceneManager.LoadScene("GameOver");
            }



    }

    public void React() // function that triggers the opponent's reaction
    {
        StartCoroutine(Reaction());
    }

    public IEnumerator Reaction()
    {
        // Clears current words selection
        nws.ClearWords();

        // Adds this turn to the counter
        nws.turnsCount++;
        Debug.Log("You just finished round " + nws.turnsCount);

        opponentBubble.SetActive(true);
        
        // A random reaction is triggered
        int randReaction = Random.Range(1, 5);
        
        if(nws.totalWordCount==0)
        {
            reaction.text = "Did you say something?";
            anim.SetInteger("Emote", 2);
        }
        else if(nws.swearCount>=3)
        {
            reaction.text = "Whoa there, watch your mouth!";
            anim.SetInteger("Emote", 3);
        }
        else
        {        
            switch (randReaction)
            {
                case 1:
                    {
                        reaction.text = "You done talking?";
                        anim.SetInteger("Emote", 2);
                        break;
                    }
                case 2:
                   {
                        reaction.text = "Am I supposed to be offended?";
                        anim.SetInteger("Emote", 2);
                        if (currentHealth+10<=maxHealth)
                        {
                         currentHealth += 10;
                         hb.SetHealth(currentHealth);

                         }                   
                        break;
                    }
                case 3:
                    {
                    reaction.text = "That is just so rude!";
                    anim.SetInteger("Emote", 3);
                    currentHealth -= 10;
                    hb.SetHealth(currentHealth);
                    break;
                    }
                case 4:
                    {
                    reaction.text = "how dare you?!?!";
                    anim.SetInteger("Emote", 4);
                    currentHealth -= 20;
                    hb.SetHealth(currentHealth);
                    break;
                    }
                 case 5:
                    {
                    reaction.text = "Have a little respect, would you?";
                    anim.SetInteger("Emote", 3);
                    currentHealth -= 5;
                    hb.SetHealth(currentHealth);
                    break;
                    }
            }
        
        }

        // The reaction text stays for 2 seconds
        yield return new WaitForSeconds(2f);
        reaction.text = null;

        // Goes back to idle animation
        anim.SetInteger("Emote", 1);

        opponentBubble.SetActive(false);
        
        // Resets all the word counters to zero
        nws.totalWordCount = 0;
        nws.nounCount = 0;
        nws.adjCount = 0;
        nws.swearCount = 0;
       
        // Display new words for next turn
        nws.DisplayWords();
       
        // Reactivates all buttons
        nws.ButtonsOn();

        yield return null;
    }
}
