using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// this shooterScript is for the default avatar and shoots normal bullets

public class ShooterScript : MonoBehaviour
{
    public GameObject Bullet;
    public float bulletSpeed;
    public KeyCode shoot;    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(shoot))
        {
            Shoot();
        }


    }

    void Shoot()
    {
        Instantiate(Bullet, this.transform.position, Quaternion.identity);
  
    }


}
