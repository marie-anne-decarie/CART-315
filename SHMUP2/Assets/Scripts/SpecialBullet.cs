using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBullet : MonoBehaviour
{

    public float bulletSpeed = 10f;
    public float yPos;

    private int collisionCounter;

    // Start is called before the first frame update
    void Start()
    {
        yPos = this.transform.position.y;
    }



    // Update is called once per frame
    void Update()
    {

        yPos += bulletSpeed;
        this.transform.position = new Vector2(this.transform.position.x, yPos);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            collisionCounter++;
            ScoreScript.score += 10;
            ScoreScript.targetHits++;
            Debug.Log(ScoreScript.targetHits);
            if (collisionCounter>=4)
            {
                Destroy(this.gameObject);
            }
        }

        if(other.gameObject.tag == "Wall")
        {
            collisionCounter++;
            if(collisionCounter>=4)
            {
                Destroy(this.gameObject);
            }

            bulletSpeed = -bulletSpeed;
        }

    }

    
}
