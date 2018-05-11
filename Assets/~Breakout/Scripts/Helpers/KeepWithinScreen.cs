using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))] // Force Renderer component to be attatched
public class KeepWithinScreen : MonoBehaviour
{
    private Renderer rend; // Renderer attached to the object 
    private Camera cam; // Camera container (variable)
    private Bounds camBounds; // Camera Bounds structure
    private float camWidth, camHeight;


    // Use this for initialization
    void Start()
    {
        // Set Camera variable to main camera 
        cam = Camera.main;
        // Get the Renderer component attached to this object
        rend = GetComponent<Renderer>();
    }

        // Updates the cambounds variable with the camera values
        void UpdateCamBounds()
            {
        // Calculate camera bounds 
        camHeight = 2f * cam.orthographicSize; // height = 2 x orthographic size 

	}

	

	void Update () {
		
	}
}
