using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeattackFinish : MonoBehaviour
{
    public GameObject player;
    float timeleft;
    public List<string> ranking;

    private void Start()
    {
        timeleft= Track2LapCountdown.laptimer;
    }
    private void OnTriggerEnter(Collider plyr)
	{
        
        
	}
    public void finishGame()
    {
        
    }
}
