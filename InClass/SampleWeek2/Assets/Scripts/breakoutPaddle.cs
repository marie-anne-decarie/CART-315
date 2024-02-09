using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakoutPaddle : MonoBehaviour
{
    public float xPos;
    public float paddlespeed = .05f;
    public float rightWall = 7;
    public float leftWall = -7;

    public KeyCode leftKey, rightKey;


    // Start is called before the first frame update
    void Start()
    {

    }

// Update is called once per frame
void Update()
    {
       if(Input.GetKey(leftKey))
        {
            if(xPos>leftWall)
            {
               xPos -= paddlespeed;
            }
        }
        if (Input.GetKey(rightKey))
        {
            if (xPos < rightWall)
            {
                xPos += paddlespeed;
            }
        }
        
        transform.position = new Vector3(xPos, transform.position.y, 0);

    }
}
