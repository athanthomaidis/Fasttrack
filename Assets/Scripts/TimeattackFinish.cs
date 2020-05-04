using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeattackFinish : MonoBehaviour
{
    public GameObject player;
    public GameObject timeScript;
    public float timeleft;
    public List<string> ranking;




    private void Start()
    {
        Debug.Log(timeScript.GetComponent<Track2LapCountdown>().lapTimer);
        timeleft = timeScript.GetComponent<Track2LapCountdown>().lapTimer;
        // timeleft= Track2LapCountdown.lapTimer;
    }
    private void Update()
    {
        //timeleft = timeScript.GetComponent<Track2LapCountdown>().lapTimer;
        // timeleft= Track2LapCountdown.lapTimer;
    }
    private void OnTriggerEnter(Collider plyr)
	{
        Debug.Log(player.GetComponent<CarController>().checkpointCounter);
        if (plyr.ToString().Equals("player (UnityEngine.BoxCollider)") && player.GetComponent<CarController>().checkpointCounter>=3)
        {
                Debug.Log("You won the game");
                ranking.Add("Player");
        }
    }
}
