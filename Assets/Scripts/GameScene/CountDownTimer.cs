﻿using System.Collections;
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
        //Time.timeScale = 0;

        if (currentTime<=0){
            //Time.timeScale = 1;
            countdownText = null;
            panel.SetActive(false);
        }
        
    }
}