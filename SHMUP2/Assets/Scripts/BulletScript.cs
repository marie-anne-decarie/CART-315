using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    public float yPos;

    // Start is called before the first frame update
    void Start()
    {
        yPos = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        yPos += speed;
        this.transform.position = new Vector2(this.transform.position.x, yPos);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            ScoreScript.score += 5;
            ScoreScript.targetHits++;
            Debug.Log(ScoreScript.targetHits);
        }
        

        if (other.gameObject.tag == "Wall")
            Destroy(this.gameObject);
    }
}
