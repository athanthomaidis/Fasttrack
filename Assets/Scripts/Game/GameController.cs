using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject humanCar;
    protected Transform carPosition;
    public GameObject startLine;
    public GameObject finishLine;
    protected int roundCounter;
    static int MAXROUNDS;

    private void Awake()
    {
        MAXROUNDS = 3;
        roundCounter = 0;
        carPosition = humanCar.transform;
    }
    private void Update()
    {

    }
    void OnTriggerEnter(Collider _objectWhichPassTheLine)
    {
        /*if (_objectWhichPassTheLine.gameObject.CompareTag(humanCar))
        {
            roundCounter++;
        }
        checkLapCounter();*/
    }

    void checkLapCounter()
    {
        if (roundCounter == MAXROUNDS + 1) // +1 because the player will trigger the collider at the start.
        {
            endGame();
        }
    }

    void endGame()
    {
        //do whatever you need to.
        Debug.Log("The game is ended, the player did 3 lap");
        //initialization();
    }

}