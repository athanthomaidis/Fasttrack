using UnityEngine;
using System.Collections;

public class CheckpointController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Is it the Player who enters the collider?
        if (!other.CompareTag("car"))
            return; //If it's not the player dont continue


        if (transform == LapsController.checkpointA[LapsController.currentCheckpoint].transform)
        {
            //Check so we dont exceed our checkpoint quantity
            if (LapsController.currentCheckpoint + 1 < LapsController.checkpointA.Length)
            {
                //Add to currentLap if currentCheckpoint is 0
                if (LapsController.currentCheckpoint == 0)
                    LapsController.currentLap++;
                LapsController.currentCheckpoint++;
            }
            else
            {
                //If we dont have any Checkpoints left, go back to 0
                LapsController.currentCheckpoint = 0;
            }
        }
    }

}
