using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class specialShooter : MonoBehaviour
{

    public GameObject specialBullet;
    public KeyCode shootSpecial;
    static public int shot = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shootSpecial)&&shot<3)
        {
            Shoot();
            shot++;
        }
 
        
            
    }

    void Shoot()
    {
        Instantiate(specialBullet, this.transform.position, Quaternion.identity);
        

    }

}
