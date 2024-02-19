using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specialShooter : MonoBehaviour
{

    public GameObject specialBullet;
    public float force;
    public KeyCode shootSpecial;

    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(shootSpecial)) 
            Instantiate(specialBullet, this.transform.position, Quaternion.identity);
    }
}
