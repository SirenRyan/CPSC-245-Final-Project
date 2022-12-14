
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
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public Text countdownTextField;
    public Statistics statistics;

   
    // Start the coroutine when told to by the Statistics script
    public void StartCountdown()
    {
        StartCoroutine(CountdownCoroutine());
    }


    /// Countdown before the timer starts/before game starts tracking score
    public IEnumerator CountdownCoroutine()
    {
        countdownTextField.text = "3";
        yield return new WaitForSeconds(1.0f);
        countdownTextField.text = "2";
        yield return new WaitForSeconds(1.0f);
        countdownTextField.text = "1";
        yield return new WaitForSeconds(1.0f);
        countdownTextField.text = "Go!";
        // start the game here
        yield return new WaitForSeconds(1.0f);
        countdownTextField.text = "";
        yield return null;
        statistics.StartGame();
    }
}
