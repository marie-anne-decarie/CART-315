using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ThereItIs()
    {
        this.gameObject.SetActive(true);
    }
}
