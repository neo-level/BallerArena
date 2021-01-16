using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    // Placeholder for the rotation speed, can be changed through in the component.
    public float rotationSpeed;
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // Get the horizontal input from the user.
        float horizontalInput = Input.GetAxis("Horizontal");

        // Rotate the camera around the focal point when the user uses the axis.
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
        
    }
}
