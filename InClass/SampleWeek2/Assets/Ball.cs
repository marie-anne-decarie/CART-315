using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public float ballSpeed;
    public float maxSpeed = 10f;
    public float minSpeed = 5f;

    public AudioSource scoreSound, blip;

    public int leftPlayerScore, rightPlayerScore;

    private int[] dirOptions = { -1, 1 };
    private int hDir, vDir;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Reset();
       
    }
    // Start the ball moving   
    public IEnumerator Launch()
        {

        yield return new WaitForSeconds(1.5f);

        // figure out the directions :3
        hDir = dirOptions[Random.Range(0, dirOptions.Length)];
        vDir = dirOptions[Random.Range(0, dirOptions.Length)];

        // Add horizontal force :o
        rb.AddForce(transform.right * ballSpeed * hDir); // Randomly goes left or right
        // Add a vertical force
        rb.AddForce(transform.up * ballSpeed * vDir); // Randomly goes up or down

        }

    private void Reset()
    {
        rb.velocity = Vector2.zero;
        ballSpeed = 2;
        transform.position = new Vector2(0, 3);
        StartCoroutine("Launch");
    }

    // if the ball goes out of bounds
    private void OnCollisionEnter2D(Collision2D other)
    {
        // did we hit a wall?
        if(other.gameObject.tag == "Wall")
        {
            blip.pitch = 0.75f;
            blip.Play();
            SpeedCheck();
        }

        // did we hit a paddle?
        if (other.gameObject.tag == "Paddle")
        {
            blip.pitch = 1f;
            blip.Play();
            SpeedCheck();
        }

        // did we hit the left wall?
        if(other.gameObject.name == "leftWall")
        {
            rightPlayerScore += 1;
            Reset();
        }

        // did we hit the right wall?
        if(other.gameObject.name == "rightWall")
        {
            leftPlayerScore += 1;
            Reset();
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
    
    
    // Update is called once per frame
    void Update()
    {
        


    }
}
