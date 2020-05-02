using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject pausePanel;
    //public GameObject pauseCountDown;

    private void Awake()
    {
        pausePanel.SetActive(false);

    }

    public void pauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void resumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void startGame()
    {

    }
    public void restartGame()
    {

    }

}
