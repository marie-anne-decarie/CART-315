using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameManager S;

    private void Awake()
    {
        S = this;
    }


    public SceneManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
            SceneManager.LoadScene("GameOver");

        if(Input.GetKeyDown(KeyCode.Alpha9))
        {
            SceneManager.LoadScene("Level 2");
            
        }

    }




   
   
}
