using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opponent : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar hb;
 
    public Text reaction; // The opponent's reaction when you attack him
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        hb.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void React()
    {
        StartCoroutine(Reaction());
    }

    public IEnumerator Reaction()
    {

        int randReaction = Random.Range(1, 5);
        switch (randReaction)
        {
            case 1:
                {
                    reaction.text = "Did you say something?";
                    break;
                }
            case 2:
                {
                    reaction.text = "Am I supposed to be offended?";
                    if(currentHealth+10<=maxHealth)
                    {
                        currentHealth += 10;
                        hb.SetHealth(currentHealth);

                    }
                    
                    break;
                }
            case 3:
                {
                    reaction.text = "That is just so rude!";
                    currentHealth -= 10;
                    hb.SetHealth(currentHealth);
                    break;
                }
            case 4:
                {
                    reaction.text = "how dare you?!?!";
                    currentHealth -= 20;
                    hb.SetHealth(currentHealth);
                    break;
                }
            case 5:
                {
                    reaction.text = "Have a little respect, would you?";
                    currentHealth -= 5;
                    hb.SetHealth(currentHealth);
                    break;
                }
        }

        yield return new WaitForSeconds(3f);

        reaction.text = null;

        yield return null;
    }
}
