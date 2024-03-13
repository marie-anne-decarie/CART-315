using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word : MonoBehaviour
{
  
    public Transform[] slots;
    public bool[] slotAvailable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        for(int i=0; i<slotAvailable.Length; i++)
        {
            if(slotAvailable[i]==true)
            {
                this.gameObject.transform.position = slots[i].position;
                slotAvailable[i] = false;
                return;
            }
        }
    }
}
