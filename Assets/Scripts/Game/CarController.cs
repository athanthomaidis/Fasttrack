using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    int roundCounter;
    int checkpointCounter;

    private void Start()
    {
        roundCounter = 0;
        checkpointCounter = 0;

    }
    private void Update()
    {
    }
    public void addCheckpoint()
    {
        checkpointCounter++;
        Debug.Log(checkpointCounter);
    }
    public void resetCheckpoint()
    {
        Debug.Log(checkpointCounter);
        checkpointCounter = 0;
    }
    public void finishROund()
    {
        if(checkpointCounter==5)
        {
            roundCounter++;
            Debug.Log(roundCounter);
        }
    }
    public int getRounds()
    {
        return roundCounter;
    }
}
