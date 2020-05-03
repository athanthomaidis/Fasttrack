using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
	//public Transform checkpoint;
	public GameObject player;
	public GameObject aiCar;
	public int checkpointCounter;
	// Use this for initialization
	void Start()
	{
        checkpointCounter = 0;
    }
    //update
    // Update is called once per frame
    private void OnTriggerEnter(Collider plyr)
	{
        Debug.Log(plyr.ToString());
        if (plyr.ToString().Equals("ai (UnityEngine.BoxCollider)"))
        {
            Debug.Log("inside AI");
            checkpointCounter++;
            aiCar.GetComponent<CarController>().addCheckpoint();

        }
        else if (plyr.ToString().Equals("player (UnityEngine.BoxCollider)"))

        {
            Debug.Log("inside PLAYER");
            checkpointCounter++;
            player.GetComponent<CarController>().addCheckpoint();
		}
        else
        {
            Debug.Log("nowhere");
        }
	}
}