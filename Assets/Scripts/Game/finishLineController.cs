using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finishLineController : MonoBehaviour
{
    public GameObject player;
    public GameObject aiCar;
    public List<string> ranking;
    public Text roundText;
    public GameObject roundTitle;

    private void Start()
    {
        Debug.Log("Finish Start");
        ranking = new List<string>();
        Debug.Log("Finish Start");
    }
    private void Update()
    {
        if(player.GetComponent<CarController>().checkpointCounter==1)
        {
            roundTitle.SetActive(false);

        }
    }


    private void OnTriggerEnter(Collider plyr)
	{
        if (plyr.ToString().Equals("ai (UnityEngine.BoxCollider)"))
        {
            aiCar.GetComponent<CarController>().finishROund();
            aiCar.GetComponent<CarController>().resetCheckpoint();
            Debug.Log("Ranking size: " + ranking.Count);
            Debug.Log("Round : " + aiCar.GetComponent<CarController>().getRounds());
            if (aiCar.GetComponent<CarController>().getRounds()==3)
            {
                ranking.Add("Computer");
                Debug.Log("Ranking size: " + ranking.Count);
            }
        }
        else if (plyr.ToString().Equals("player (UnityEngine.BoxCollider)"))

        {
            
            player.GetComponent<CarController>().finishROund();
            roundTitle.SetActive(true);
            int roundNumber = player.GetComponent<CarController>().getRounds() + 1;
            roundText.text = roundNumber.ToString();
            player.GetComponent<CarController>().resetCheckpoint();

            Debug.Log("Round : "+player.GetComponent<CarController>().getRounds());


            if (player.GetComponent<CarController>().getRounds() == 3)
            {
                ranking.Add("Player");
                
            }
        }
        
	}
    public bool finishGame()
    {
        if(ranking.Count==2)
        {
            return true;
        }
        return true;
    }
}
