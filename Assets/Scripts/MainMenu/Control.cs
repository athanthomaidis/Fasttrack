﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("TrackSelector");
    }
    public void startFirstTrack()
    {
        SceneManager.LoadScene("GameScene");

    }
    public void startSecondTrack()
    {
        SceneManager.LoadScene("Track2");
    }
    public void exitGame()
    {
        Application.Quit();
    }
    public void goBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void options()
    {
        SceneManager.LoadScene("Options");
    }

}
