﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    int roundCounter;
    int checkpointCounter;

    private void Sta()
    {
        roundCounter = 0;
        checkpointCounter = 0;

    }


    public void addCheckpoint()
    {
        checkpointCounter++;
    }
    public void resetCheckpoint()
    {
        checkpointCounter = 0;
    }
    public void finishROund()
    {
        if(checkpointCounter==5)
        {
            roundCounter++;
        }
    }
    public int getRounds()
    {
        return roundCounter;
    }


    
}
