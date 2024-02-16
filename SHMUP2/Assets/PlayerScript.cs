using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public KeyCode leftKey, rightKey;
    public float playerSpeed = 0.5f;
    public float xPos;
    public float leftWall, rightWall;

    public GameObject Bullet;

    public KeyCode shoot;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftKey))
        {
            if(xPos>leftWall)
                xPos -= playerSpeed;
        }
        
        if (Input.GetKey(rightKey))
        {
             if(xPos<rightWall)
                xPos += playerSpeed;
        }

        transform.position = new Vector3(xPos, transform.position.y, 0);


        if (Input.GetKeyDown(shoot))
            Shoot();
    }

    void Shoot()
    {
        Instantiate(Bullet, this.transform.position, Quaternion.identity); 

    }

}
