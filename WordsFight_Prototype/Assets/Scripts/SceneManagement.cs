using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "GameOver")
        {
            anim.SetBool("YouLost", false);
        }
        else if (sceneName == "GameOverB")
        {
            anim.SetBool("YouLost", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Play()
    {
        SceneManager.LoadScene("New");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("New");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("OpenTitle");
    }

}
