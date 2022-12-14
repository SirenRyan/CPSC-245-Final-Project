
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

public class TargetShooter : MonoBehaviour
{
    [SerializeField] Camera cam;

    public GameObject BulletHole;

  // Onclick creates a raycast that acts as the "bullet" to destroy the target if you aim at it accurately

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Target target = hit.collider.gameObject.GetComponent<Target>();

             

                if (target != null)
                {
                    target.Hit();
                }

                else
                {
                    // Instatiate bullet holes onto wall ONLY
                    Instantiate(
                        BulletHole, hit.point + (hit.normal * 0.1f),
                        Quaternion.FromToRotation(Vector3.up, hit.normal)
                        );
                }
            }

        }
    }


}
