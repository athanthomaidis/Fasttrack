using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 3f;

    [SerializeField] Text countdownText;
    [SerializeField] GameObject panel;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }
    void Update(){
        currentTime -= 1*Time.deltaTime;
        countdownText.text = currentTime.ToString("0");


        if (currentTime<=0){
            countdownText = null;
            panel.SetActive(false);
            this.enabled = false;
        }
        
    }

    public void displayTimer()
    {

    }
    public void hideTimer()
    {
        //Time.timeScale = 1;
        countdownText = null;
        panel.SetActive(false);
    }
}
