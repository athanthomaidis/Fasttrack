using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track2GameController : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject finishLine;
    public GameObject timerText;
    public float timeleft;

    private void Start()
    {
        timeleft = timerText.GetComponent<Track2LapCountdown>().lapTimer;
    }

    private void Update()
    {
        timeleft = timerText.GetComponent<Track2LapCountdown>().lapTimer;
        Debug.Log("Update");
        if(timeleft>0.0f && finishLine.GetComponent<TimeattackFinish>().ranking.Count > 0)
        {
            timerText.GetComponent<Track2LapCountdown>().lapTimer = 0f;
            //player wins finish game
            Time.timeScale = 0;
            winPanel.SetActive(true);
        }
        else if(timeleft<=0.0f)
        {
            timerText.GetComponent<Track2LapCountdown>().lapTimer = 0f;
            Time.timeScale = 0;
            losePanel.SetActive(true);
        }
        
    }
}
