using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAttackCheckpoint : MonoBehaviour
{
	//public Transform checkpoint;
	public GameObject player;
	// Use this for initialization

    //update
    // Update is called once per frame
    private void OnTriggerEnter(Collider plyr)
	{
        if (plyr.ToString().Equals("player (UnityEngine.BoxCollider)"))
        {
            player.GetComponent<CarController>().addCheckpoint();
		}
	}
}