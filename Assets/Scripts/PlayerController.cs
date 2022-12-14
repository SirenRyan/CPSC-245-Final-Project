
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

public class PlayerController : MonoBehaviour
{

    [SerializeField] Transform cameraHolder;
    [SerializeField] float mouseSensitivity = 1;
    float verticalLookRotation;

    // Hide cursor so player only sees Crosshair, and lock it to the center of the screen

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


        // makes camera move left and right and up and down with player/mouse movement
    private void Update()
    {
         transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * mouseSensitivity);

        verticalLookRotation -= Input.GetAxisRaw("Mouse Y") * mouseSensitivity;

        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

        cameraHolder.localEulerAngles = new Vector3(verticalLookRotation, 0, 0);
    }
       
}
