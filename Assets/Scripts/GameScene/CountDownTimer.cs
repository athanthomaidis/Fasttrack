using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown(3));
    }
    IEnumerator Countdown(int seconds){
        int count = seconds;
       
        while (count > 0) {
           
            // display something...
            yield return new WaitForSeconds(1);
            count --;
        }
       
        // count down is finished...
        StartGame();
    }
    void StartGame()
    {
        // do something...
    }
}
