using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Variables
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0f;
    bool cameraMovementEnabled = true; // 변수를 추가하여 카메라 움직임을 제어
    // public GameObject successCanvas;

    void Start()
    {
        // Lock and Hide the Cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (cameraMovementEnabled)
        {
            // Collect Mouse Input
            float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
            float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;

            // Rotate the Camera around its local X axis
            cameraVerticalRotation -= inputY;
            cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
            transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

            // Rotate the Player Object and the Camera around its Y axis
            player.Rotate(Vector3.up * inputX);
        }

        // if (Input.GetKeyDown(KeyCode.P))
        // {
        //     // Toggle camera movement on/off when 'p' is pressed
        //     cameraMovementEnabled = !cameraMovementEnabled;

        //     // Show or hide the cursor based on camera movement state
        //     Cursor.visible = cameraMovementEnabled;
        //     Cursor.lockState = cameraMovementEnabled ? CursorLockMode.Locked : CursorLockMode.None;
        // }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Release cursor and stop camera movement when 'Escape' is pressed
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            cameraMovementEnabled = false;
        }
    }


    // public void StopCam()
    // {
    //     if (Input.GetKeyDown(KeyCode.P))
    //     {
    //         // Toggle camera movement on/off when 'p' is pressed
    //         cameraMovementEnabled = !cameraMovementEnabled;

    //         // Show or hide the cursor based on camera movement state
    //         Cursor.visible = cameraMovementEnabled;
    //         Cursor.lockState = cameraMovementEnabled ? CursorLockMode.Locked : CursorLockMode.None;
    //     }

    //     // if (successCanvas.activeSelf)
    //     // {
    //     //     // Toggle camera movement on/off when 'p' is pressed
    //     //     cameraMovementEnabled = !cameraMovementEnabled;

    //     //     // Show or hide the cursor based on camera movement state
    //     //     Cursor.visible = cameraMovementEnabled;
    //     //     Cursor.lockState = cameraMovementEnabled ? CursorLockMode.Locked : CursorLockMode.None;
    //     // }
    // }
}
