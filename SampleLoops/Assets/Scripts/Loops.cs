using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
            while(i<3)
        {
            print("Loop: " + i);
            i++;
        }

        string str = "Hello!";
        foreach (char chr in str)
        {
            print(chr);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
