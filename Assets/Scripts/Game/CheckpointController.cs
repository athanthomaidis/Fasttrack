using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
	public Transform checkpoint;
	GameObject player;
	public int checkpointCounter;
	// Use this for initialization


	void Start()
	{
		checkpointCounter = 0;
		player = GameObject.FindWithTag("Player");
	}

	// Update is called once per frame
	void OnTriggerEnter(Collider plyr)
	{
		if (plyr.gameObject.tag == "Player")
		{
			checkpointCounter++;
		}
	}
}