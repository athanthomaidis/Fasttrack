using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
	//public Transform checkpoint;
	public GameObject player;
	public int checkpointCounter;
	// Use this for initialization
	void Start()
	{
        Debug.Log(player.gameObject.tag);
        checkpointCounter = 0;
		//player = GameObject.FindWithTag("Player");
        //Debug.Log(player.gameObject.tag);

    }
    //update


    // Update is called once per frame
    private void OnTriggerEnter(Collider plyr)
	{
        checkpointCounter++;
        Debug.Log("inside");
		if (plyr.tag.Equals("Player"))
		{
            Debug.Log("inside if");

            checkpointCounter++;
		}
	}
}