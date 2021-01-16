using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    // Set the range where the enemies can spawn.
    private float _spawnRange = 9.0f;

    // Start is called before the first frame update
    private void Start()
    {
        // Instantiate a new enemy prefab, spawning the enemy at the given location.
        Instantiate(enemyPrefab, position: GenerateRandomSpawnPosition(), rotation: enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    // // Spawns an enemy on a random location.
    // private void SpawnEnemyOnRandomLocation()
    // {
    // }

    private Vector3 GenerateRandomSpawnPosition()
    {
        float spawnPositionX = Random.Range(-_spawnRange, _spawnRange);
        float spawnPositionZ = Random.Range(-_spawnRange, _spawnRange);

        // Create a vector with random generated numbers.
        Vector3 randomPosition = new Vector3(x: spawnPositionX, y: 0, z: spawnPositionZ);
        
        return randomPosition;
    }
}