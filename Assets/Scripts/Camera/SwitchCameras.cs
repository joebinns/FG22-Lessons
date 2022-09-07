using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    // Change priority of cameras to switch (suddenly)
    private float defaultPriority = 0;
    private float index = 0; // Index refers to the current camera
    public Camera[] cameras;

    private void Start()
    {
        Switch();
    }

    private void Switch()
    {
        UpdateCameraPriority();
            
        index++;
        index %= cameras.Length; // Optimisation: Avoids an if statement
    }

    private void UpdateCameraPriority()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].depth = defaultPriority;

            if (index == i)
            {
                cameras[i].depth += 1;
            }
        }
    }

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UpdateCameraPriority();
        }
    }
}
