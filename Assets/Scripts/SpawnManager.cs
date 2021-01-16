using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;


    public int amountOfEnemies;
    public int spawnWave = 1;

    // Set the range where the enemies can spawn.
    private float _spawnRange = 9.0f;

    // Start is called before the first frame update
    private void Start()
    {
        SpawnEnemyWave(spawnWave);
        RandomPowerUpSpawn();
    }

    // Update is called once per frame
    private void Update()
    {
        amountOfEnemies = FindObjectsOfType<Enemy>().Length;

        if (amountOfEnemies == 0)
        {
            spawnWave++;
            SpawnEnemyWave(spawnWave);
            RandomPowerUpSpawn();
        }
    }

    // Spawns a wave of enemies on a random location.
    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        // Generate the amount of enemies till the given number.
        for (int enemies = 0; enemies < enemiesToSpawn; enemies++)
        {
            // Instantiate a new enemy prefab, spawning the enemy at the given location.
            Instantiate(enemyPrefab, position: GenerateRandomSpawnPosition(), rotation: enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateRandomSpawnPosition()
    {
        float spawnPositionX = Random.Range(-_spawnRange, _spawnRange);
        float spawnPositionZ = Random.Range(-_spawnRange, _spawnRange);

        // Create a vector with random generated numbers.
        Vector3 randomPosition = new Vector3(x: spawnPositionX, y: 0, z: spawnPositionZ);

        return randomPosition;
    }

    private void RandomPowerUpSpawn()
    {
        Instantiate(powerUpPrefab, GenerateRandomSpawnPosition(), rotation: powerUpPrefab.transform.rotation);
    }
}