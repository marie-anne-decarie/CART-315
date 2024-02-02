using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float yPos;
    public float paddlespeed = .05f;
    public float topWall = 3.5f;
    public float bottomWall = -3.5f;

    public KeyCode upKey, downKey;


    // Start is called before the first frame update
    void Start()
    {

    }

// Update is called once per frame
void Update()
    {
       if(Input.GetKey(downKey))
        {
            if(yPos>bottomWall)
            {
               yPos -= paddlespeed;
            }
        }
        if (Input.GetKey(upKey))
        {
            if (yPos < topWall)
            {
                yPos += paddlespeed;
            }
        }
        
        transform.position = new Vector3(transform.position.x, yPos, 0);

    }
}
