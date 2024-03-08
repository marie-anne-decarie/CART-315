using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class TimerScript : MonoBehaviour {
    private Text timerText;
    private float levelTime;
    
    // Start is called before the first frame update
    void Start() {
        timerText = GetComponent<Text>();
        ResetTimer();
    }
    
    public void ResetTimer(){
        levelTime = 30.0f;
    }

    // Update is called once per frame
    void FixedUpdate() {
        if(levelTime > 0){
            levelTime -= Time.deltaTime;
            timerText.text = System.Math.Round(levelTime, 1) + " SECONDS LEFT";       
        }
        else {
            SceneManager.LoadScene("GameOver");
        }
    }

}

