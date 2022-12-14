
/*
CPSC245_Final_CLEMENTS
Ryan Clements
2374337
rclements@chapman.edu
CPSC 245-01
FINAL

Relatively simple aim trainer, accurately clicking on the target adds a point to your score counter and then spawns the target in a new,
randominzed location within the target bounds set. Currently I have the time set to last 20 seconds, but that is mainly for the purpose of testing/viewing
the game for class and grading, otherwise I think I would make it around 1 minute. Once the timer is up, switches to a new scene where you can choose to
restart the aim trainer or quit entirely.

*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Statistics : MonoBehaviour
{
    public static int scoreInt = 0;
    public static float timer = 0;



    public Text Score;
    public Text TimeText;

    public CountdownController CountdownController;

    bool CoroutineExecuted = false;

    /// On Start, run the StartCountdown method in the CountdownController script
    

    public void Start()
    {
        CountdownController.StartCountdown();
    }
 


    // Basically, I used this co-routine to not start the timer/score tracking until the 3,2,1,GO! co-routine from the Countdown Controller script has finished running
    public void StartGame()
    {
        StartCoroutine(waitTime());
    }
 

    // Reset score, start countdown coroutine
    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(0);
        scoreInt = 0;
        CoroutineExecuted = true;
    }
   
        // Update Score and Time texts to show current Time and Score
   public void Update()
    {
        if (CoroutineExecuted)
        {
            Score.text = "Score: " + scoreInt;
            TimeText.text = "Time: " + timer;
            timer += Time.deltaTime;

            if (timer > 20)
            {
                // "end" game by switching to EndMenu scene
                SceneManager.LoadScene(1);
                Debug.Log("GameOver");

                // Re-show cursor and unlock it so you can navigate the End Menu
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

                // Set timer back to 0 
                timer = 0;

                // Set score back to 0
                scoreInt = 0;

            }
        }
    }

    


}


