
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

public class Target : MonoBehaviour
{
    // Move the target to a new location when Hit, and increase score by 1
    public void Hit()
    {
        transform.position = TargetBounds.Instance.GetRandomPosition();

        Statistics.scoreInt += 1;

    }




}
