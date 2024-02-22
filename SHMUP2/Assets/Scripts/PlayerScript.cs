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
    public GameObject defaultAvatar, specialAvatar;

    public KeyCode shoot;

    public float force;

    private int whichAvatarIsOn = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        defaultAvatar.gameObject.SetActive(true);
        specialAvatar.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Switching between default pink sprite and special yellow sprite
        if (Input.GetKeyDown(KeyCode.Z) && ScoreScript.deservePowerUp)
        {
            defaultAvatar.gameObject.SetActive(false);
            specialAvatar.gameObject.SetActive(true);

        }

        if(specialShooter.shot>=3)
        {
            defaultAvatar.gameObject.SetActive(true);
            specialAvatar.gameObject.SetActive(false);
            specialShooter.shot = 0;

        }

        // Move left and right
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

    }

    void SwitchAvatar() // (Currently unused) :'(
    {
        Debug.Log("You switched the character");

        switch(whichAvatarIsOn)
        {
            case 1:
                // specialAvatar (2) is now on
                whichAvatarIsOn = 2;
                // activate specialAvatar
                defaultAvatar.gameObject.SetActive(false);
                specialAvatar.gameObject.SetActive(true);
                break;
            case 2:
                // defaultAvatar (1) is now on
                whichAvatarIsOn = 1;
                defaultAvatar.gameObject.SetActive(true);
                specialAvatar.gameObject.SetActive(false);
                break;

        }


  

    }



}
