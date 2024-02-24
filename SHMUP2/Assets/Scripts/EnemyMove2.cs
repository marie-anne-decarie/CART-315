using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove2 : MonoBehaviour
{

    public float enemySpeed;
    public float xPos, yPos;
    public float timer = 10.5f;


    void Start()
    {
        xPos = this.transform.position.x;
        yPos = this.transform.position.y;
    }

    private void Update()
    {
        timer -= 1*Time.deltaTime;
        xPos += enemySpeed;
        yPos -= enemySpeed;
        if(timer<=0)
        {
            xPos -= enemySpeed;
            timer = 1f;
        }
        this.transform.position = new Vector3(xPos, yPos, 0);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "BotWall")
            Destroy(this.gameObject);

        if (other.gameObject.tag == "Player")
        {
            ScoreScript.lives -= 1;
            Destroy(this.gameObject);
        }
        


    }


}
