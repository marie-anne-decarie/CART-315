using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedController : MonoBehaviour



{
    public float xLoc = 0;
    public float xSpeed = 0.1f;
    public GameObject bed;
    public SpriteRenderer sr;
    public int score;
    
    
    // Start is called before the first frame update
    void Start()
    {
        sr = this.GetComponent<SpriteRenderer>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Z) && xLoc > -11f) 
        {
        xLoc -= xSpeed;
        }
    if (Input.GetKey(KeyCode.X) && xLoc < 11f)

    {
        xLoc += xSpeed;
    }

        this.transform.position = new Vector3(
            xLoc,
            transform.position.y,
            transform.position.z);

    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "sleepy") score += 1;

        Destroy(other.gameObject);
    }

 
}
