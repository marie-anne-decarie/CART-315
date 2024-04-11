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

   // Keeps track of how many times you made the opponent lose points in a row
    public int hitsStreak = 0;

    public TextAsset hitReactions_asset;
    public TextAsset missReactions_asset;

    public List<string> hitReactions = new List<string>();
    public List<string> missReactions = new List<string>();

    private int defense;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        hb.SetMaxHealth(maxHealth);

        reaction.text = null;
        opponentBubble.SetActive(false);

        LoadReactions();
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

        if(nws.turnsCount>5 && currentHealth==100)
        {
            currentHealth = 99;
            SceneManager.LoadScene("GameOverB");
        }


    }

    public void React() // function that triggers the opponent's reaction
    {
        nws.CalculateAttackWorth();
        StartCoroutine(Reaction());
    }

    public IEnumerator Reaction()
    {
        // Clears current words selection
        nws.ClearWords();

        // Adds this turn to the counter
        nws.turnsCount++;
        // Debug.Log("You just finished round " + nws.turnsCount);

        opponentBubble.SetActive(true);
        
        
        // the special ??? attack triggers a special reaction: 
        if(nws.specialAttack)
         {
            reaction.text = "What the hell dude?!?!?!";
            anim.SetInteger("Emote", 4);
            currentHealth -= 25;
            hb.SetHealth(currentHealth);
         }

        // if you didn't write anything and just attacked, you get this message
        else if(nws.totalWordCount==0)
        {
            reaction.text = "Did you say something?";
            hitsStreak = 0;
            anim.SetInteger("Emote", 2);
        }
        // if you use the swear word option with a bit too much enthusiasm:
        else if(nws.swearCount>nws.nounCount+nws.adjCount || nws.swearCount>=3)
        {
            reaction.text = "Whoa there, watch your mouth!";
            hitsStreak = 0;
            anim.SetInteger("Emote", 3);
            if (currentHealth + 10 <= maxHealth)
            {
                currentHealth += 10;
                hb.SetHealth(currentHealth);
            }
            else
            {
                currentHealth = 100;
                hb.SetHealth(currentHealth);
            }
        }

        // if you don't put any punctuation or forget to insert a noun
        else if ((nws.nounCount<1 || nws.punctuationCount<1))
        {
            reaction.text = "Learn some grammar, would you?";
            hitsStreak = 0;
            anim.SetInteger("Emote", 2);
            if (currentHealth + 5 <= maxHealth)
            {
                currentHealth += 5;
                hb.SetHealth(currentHealth);
            }
            else
            {
                currentHealth = 100;
                hb.SetHealth(currentHealth);
            }
        }
        
        // now if none of those previous conditions apply, you get a reaction adapted to your attack's worth:
        else
        {
            defense = Random.Range(1, 50); // The higher your score, the more chance you get to hurt the opponent

            if(nws.attackWorth>defense)
            {
                Hit(); 
            }
            else
            {
                Miss();
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
        nws.punctuationCount = 0;

        // Reset the special attack
        nws.specialAttack = false;

        // Resets the attack count
        nws.attackWorth = 0;
       
        // Display new words for next turn
        nws.DisplayWords();
       
        // Reactivates all buttons
        nws.ButtonsOn();

        yield return null;
    }

    public void ResetStreak()
    {
        hitsStreak = 0;
    }

    public void Hit()
    {
        int randReaction = Random.Range(0, hitReactions.Count);
        reaction.text = hitReactions[randReaction];
        anim.SetInteger("Emote", 3);
        currentHealth -= (nws.attackWorth - defense);
        hb.SetHealth(currentHealth);
        hitsStreak++;
    }

    public void Miss()
    {
        int randReaction = Random.Range(0, missReactions.Count);
        reaction.text = missReactions[randReaction];
        anim.SetInteger("Emote", 2);
        if((currentHealth+(defense - nws.attackWorth)<=100))      
        {
            currentHealth += (defense - nws.attackWorth);
        }
        else
        {
            currentHealth = 100;
        }
       hb.SetHealth(currentHealth);
    }

    void LoadReactions() // loads the possible reactions from the opponent
    {
        hitReactions_asset = Resources.Load("hitReactions") as TextAsset;
        string[] hitReactionsList = hitReactions_asset.text.Split('\n');
        for (int i = 0; i < hitReactionsList.Length; i++)
        {
            hitReactions.Add(hitReactionsList[i]);
        }
        missReactions_asset = Resources.Load("missReactions") as TextAsset;
        string[] missReactionsList = missReactions_asset.text.Split('\n');
        for (int i = 0; i < missReactionsList.Length; i++)
        {
            missReactions.Add(missReactionsList[i]);
        }


    }
}
