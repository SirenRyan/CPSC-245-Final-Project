
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

public class TargetBounds : MonoBehaviour
{


    /// Allow this variable to be accessed from anywhere so it can be referenced in the Targe script

    public static TargetBounds Instance;

    void Awake()
    {
        Instance = this;

    }

    [SerializeField] BoxCollider col;


    /// Uses the box collider (with it's collider turned off) to act as the "bounds" with which the targets spawn in
    public Vector3 GetRandomPosition()
    {
        Vector3 center = col.center + transform.position;


        // find min of the box collider I am using as the area where targets will spawn by dividing the size of the collider in half
        float minX = center.x - col.size.x / 2f;
        float maxX = center.x + col.size.x / 2f;

        float minY = center.y - col.size.y / 2f;
        float maxY = center.y + col.size.y / 2f;

        float minZ = center.z - col.size.z / 2f;
        float maxZ = center.z + col.size.z / 2f;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxX);
        float randomZ = Random.Range(minZ, maxZ);

        // Use these random values to generate a Vector3 to spawn the targets in random locations within the box collider

        Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);

        return randomPosition;

    }

}
