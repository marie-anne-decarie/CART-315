using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructionsScript : MonoBehaviour
{

    private void Start()
    {
        this.gameObject.SetActive(false); 
    }

    public void ShowInstructions()
    {
        this.gameObject.SetActive(true);
    }

    public void HideInstructions()
    {
        this.gameObject.SetActive(false);
    }
}
