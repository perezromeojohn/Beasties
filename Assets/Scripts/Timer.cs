using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timeRemaining = 15; //in seconds
    public bool timerIsRunning = false;
    public GameObject canvas;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;  
    }

    // Update is called once per frame
    void Update()
    {
        Transform textTr = canvas.transform.Find("timer");
        text = textTr.GetComponent<Text>();

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                text.text = "00:00:00"; // because idk , it turns to negative
                    
                Debug.Log("Do something when timer runs out");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }


    private void DisplayTime(float timeToDisplay)
    {
        if (timeRemaining > 10)
        {
            timeToDisplay += 1; // because timer stuff, E.G. 1 sec remaining === 0.9,0.8,0.7 ... 
                                // so it wouldnt stop immediately at zero
                                // unless milliseconds is shown, then we dont need this
                                // https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/  reference
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = (timeToDisplay % 1) * 1000;

        text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if (timeRemaining <= 10) //if 10 seconds remaining, show milliseconds, change color red
        {
            text.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliSeconds);
            text.color = Color.red;
        }
    }
}
