using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramover : MonoBehaviour
{
    public Camera mainCamera; // Reference to the Camera in the scene

    // Function to move the camera down by 22 units
    public void MoveCameraDownBy22()
    {
        // Move the camera's position down by exactly 22 units
        mainCamera.transform.position += new Vector3(0, -22, 0);
    }
}
