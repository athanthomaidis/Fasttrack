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
		//player = GameObject.FindWithTag("Player");
        //Debug.Log(player.gameObject.tag);

    }
    //update


    // Update is called once per frame
    private void OnTriggerEnter(Collider plyr)
	{
        if(plyr.tag.Equals(aiCar.tag))
        {
            Debug.Log("inside AI");
            checkpointCounter++;
        }
		if (plyr.tag.Equals(player.tag))
		{
            Debug.Log("inside PLAYER");
            checkpointCounter++;
		}
	}
}