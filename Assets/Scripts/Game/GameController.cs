using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject humanCar;
    public GameObject AIcar1;
    protected Transform carPosition;
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
        if(finishLine.GetComponent<finishLineController>().ranking.Count>0)
        {
            Debug.Log(finishLine.GetComponent<finishLineController>().ranking.Count);
            Debug.Log(finishLine.GetComponent<finishLineController>().ranking[0]);
            if(finishLine.GetComponent<finishLineController>().ranking[0]=="Player")
            {
                //player wins finish game
                endGame();
            }
            else if(finishLine.GetComponent<finishLineController>().ranking.Count==2)
            {
                endGameAI();
                //computer wins but wait until player reach finish 
            }
        }
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
        Debug.Log("The game is ended, the player wins");
        //initialization();
    }

    void endGameAI()
    {
        //do whatever you need to.
        Debug.Log("The game is ended AI WINS");
        //initialization();
    }


}