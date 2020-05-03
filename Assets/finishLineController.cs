using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishLineController : MonoBehaviour
{
    public GameObject player;
    public GameObject aiCar;
    public List<string> ranking;

    private void Start()
    {
        ranking = new List<string>();
    }
    private void OnTriggerEnter(Collider plyr)
	{
        if (plyr.ToString().Equals("ai (UnityEngine.BoxCollider)"))
        {
            aiCar.GetComponent<CarController>().finishROund();
            if(aiCar.GetComponent<CarController>().getRounds()>3)
            {
                ranking.Add("Computer");
            }
        }
        else if (plyr.ToString().Equals("player (UnityEngine.BoxCollider)"))

        {
            player.GetComponent<CarController>().finishROund();
            if (player.GetComponent<CarController>().getRounds() > 3)
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
