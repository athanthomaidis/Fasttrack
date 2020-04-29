using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    private void Awake()
    {
        
    }
    public void startGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void exitGame()
    {
        Application.Quit();
    }
    public void goBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
