using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour 
{
    GameObject humanCar;
    GameObject startLine;
    GameObject finishLine;
    int roundCounter;
    static int MAXROUNDS;

    private void Awake()
    {
        MAXROUNDS = 3;
        roundCounter = 0;
    }
    private void Update()
    {
        
    }

}
