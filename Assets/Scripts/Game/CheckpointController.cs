using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
	//public Transform checkpoint;
	public GameObject player;
	public GameObject aiCar;
	// Use this for initialization

    //update
    // Update is called once per frame
    private void OnTriggerEnter(Collider plyr)
	{
        if (plyr.ToString().Equals("ai (UnityEngine.BoxCollider)"))
        {
            aiCar.GetComponent<CarController>().addCheckpoint();

        }
        else if (plyr.ToString().Equals("player (UnityEngine.BoxCollider)"))
        {
            player.GetComponent<CarController>().addCheckpoint();
		}
	}
}