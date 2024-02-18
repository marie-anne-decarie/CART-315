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
    public GameObject specialBullet;

    public Sprite special;

    public KeyCode shoot;

    private int changeCount=0;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = special;
            changeCount++;

        }
        

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


        if (Input.GetKeyDown(shoot) && (changeCount / 2 == 0))
            Shoot();
        else if (Input.GetKeyDown(shoot))
            SpecialShoot();
    }

    void Shoot()
    {
        Instantiate(Bullet, this.transform.position, Quaternion.identity); 

    }

    void SpecialShoot()
    {

        Instantiate(specialBullet, this.transform.position, Quaternion.identity);
    }

}
