using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Track2LapCountdown : MonoBehaviour
{
    public float lapTimer;
    bool lapComplete;
     [SerializeField] Text countdownText;

    private void Awake()
    {
        lapTimer = 10f;
    }
    // Start is called before the first frame update
    void Start()
    {
         DisplayLapTime(lapTimer);
    }

    // Update is called once per frame
    void Update()
    {
        lapTimer -=0.2f*Time.fixedDeltaTime;
        DisplayLapTime(lapTimer);
        //Check if lap complete
        if(lapComplete){
            DisplayLapTime(lapTimer);
            lapTimer = 0f;
        }
    }
    void DisplayLapTime(float _time)
    {
        countdownText.text = "Timer:    "+_time.ToString();
        Debug.Log(_time);
    }
}
