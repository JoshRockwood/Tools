using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    private float spawnRangeX= 20.0f;
    private float spawnPositionZ = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        // Spawns a UFO at interval with delay
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    void SpawnRandomUFO ()
    {
        // Spawns UFO at random location on x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1.3f, spawnPositionZ);
        // Spawns random UFO from array
        int ufoIndex = Random.Range(0, ufoPrefabs.Length);
        // Creates UFO
        Instantiate((ufoPrefabs[ufoIndex]), spawnPos, ufoPrefabs[ufoIndex].transform.rotation);
    }
}
