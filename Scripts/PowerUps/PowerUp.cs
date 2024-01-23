using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnPowerUp : MonoBehaviour
{
    public GameObject powerUp;
    public Transform spawner;
    private float startDelay = 5.0f;
    private float spawnInterval = 5.0f;
    private float spawnRangeX =  25.0f;
    private float spawnPositionZ = 25.0f; 

    // Start is called before the first frame update
    void Start()
    {
        // Spawn powerup with delay
        InvokeRepeating("CreatePowerUp", startDelay, spawnInterval);
    }

    void CreatePowerUp()
    {
        // Creates power up with random x-axis variable
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1.3f, spawnPositionZ);
        // Instantiates powerup
        Instantiate(powerUp, spawnPos, powerUp.transform.rotation);
    }
}