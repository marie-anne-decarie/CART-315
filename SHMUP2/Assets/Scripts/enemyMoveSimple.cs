using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMoveSimple : MonoBehaviour
{
    public float enemySpeed;
    float yPos;
    
    // Start is called before the first frame update
    void Start()
    {
        yPos = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        yPos -= enemySpeed;
        this.transform.position = new Vector3(this.transform.position.x, yPos, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "BotWall")
                Destroy(this.gameObject);
        
        if (other.gameObject.tag == "Player")
        {
            ScoreScript.lives -= 1;
            Destroy(this.gameObject);
        }

    }
}

