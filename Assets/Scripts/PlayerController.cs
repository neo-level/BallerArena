using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Add a speed variable that can be changed in the component to tweak.
    private float _speed = 10.0f;

    // Get the Rigidbody class.
    private Rigidbody _playerRifRigidbody;
    private GameObject _focalPoint;
    
    // Start is called before the first frame update
    private void Start()
    {
        // Get the rigidbody component from the object.
        _playerRifRigidbody = GetComponent<Rigidbody>();
        
        // get the focal point game object in our scene.
        _focalPoint = GameObject.Find("FocalPoint");
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the "Vertical input" from the arrow keys that the player uses.
        float forwardInput = Input.GetAxis("Vertical");
        
        // Add force when the player uses his input. with the focal point as reference.
        _playerRifRigidbody.AddForce(_focalPoint.transform.forward * (_speed * forwardInput));
    }
}
