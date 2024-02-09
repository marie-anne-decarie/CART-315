using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class breakoutBall : MonoBehaviour
{
    private Rigidbody2D rb;
    public float ballSpeed;
    public float maxSpeed = 10f;
    public float minSpeed = 2f;

    public int lives;

    public AudioSource blip;

    public Text leftScore, rightScore;
    public Text victory;

    private int[] dirOptions = { -1, 1 };
    private int hDir;

    private bool gameRunning;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lives = 4;
        Reset();
       
    }
       // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gameRunning)
            StartCoroutine(Launch());
    }
  
    
    // Start the ball moving   
    public IEnumerator Launch()
        {
        
        GetComponent<TrailRenderer>().enabled = true;

        yield return null;

        gameRunning = true;
      
        hDir = dirOptions[Random.Range(0, dirOptions.Length)];
        // Add a vertical force
        //rb.AddForce(transform.right * ballSpeed * hDir); // randomly goes left or right
        rb.AddForce(transform.up * -1f); 

        }

    private void Reset()
    {
        GetComponent<TrailRenderer>().enabled = false;

        gameRunning = false;

        rb.velocity = Vector2.zero;
        ballSpeed = 2;
        transform.position = new Vector2(0, -2);
    }

    // if the ball goes out of bounds
    private void OnCollisionEnter2D(Collision2D other)
    {
        // did we hit the bottom wall?
        if(other.gameObject.tag == "Reset")
        {
            GameManager.S.LoseLife();
            Reset();
        }

        // did we hit a paddle?
        if (other.gameObject.tag == "Paddle")
        {
            blip.pitch = 1f;
            blip.Play();
            SpeedCheck();
        }

        // did we hit the side walls?
        if(other.gameObject.tag == "Wall")
        {
            SpeedCheck();
        }

        if (other.gameObject.tag == "Brick")
        {
            blip.pitch = 0.75f;
            blip.Play();
            int r = Random.Range(10, 20);
            GameManager.S.AddPoints(r);

            Destroy(other.gameObject);
        }

    }

    private void SpeedCheck()
    {
        // prevents ball from going too fast
        if (Mathf.Abs(rb.velocity.x) > maxSpeed) rb.velocity = new Vector2(rb.velocity.x * 0.9f, rb.velocity.y);
        if(Mathf.Abs(rb.velocity.y) > maxSpeed) rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.9f);

        // prevents ball from going too slow
        if (Mathf.Abs(rb.velocity.x) < minSpeed) rb.velocity = new Vector2(rb.velocity.x * 1.1f, rb.velocity.y);
        if (Mathf.Abs(rb.velocity.y) < minSpeed) rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 1.1f);

        // prevents too shallow an angle
        if(Mathf.Abs(rb.velocity.x) < minSpeed)
        {
           rb.velocity = new Vector2((rb.velocity.x < 0) ? -minSpeed : minSpeed, rb.velocity.y);

        }

        if (Mathf.Abs(rb.velocity.y) < minSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, (rb.velocity.y < 0) ? -minSpeed : minSpeed);

        }

        Debug.Log(rb.velocity);

    }
    
    
   
}
