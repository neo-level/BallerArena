using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 5.0f;
    private Rigidbody _enemyRigidbody;

    private GameObject _player;

    // Start is called before the first frame update
    private void Start()
    {
        // get the rigidbody of the object.
        _enemyRigidbody = GetComponent<Rigidbody>();
        // find the player object.
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    private void Update()
    {
        // Move the enemy in the direction of the user by subtracting the player position with the enemies.
        // Addition of normalization to prevent a multitude of force being applied when the distance vector is increased.
        _enemyRigidbody.AddForce((_player.transform.position - transform.position).normalized * _speed);
    }
}