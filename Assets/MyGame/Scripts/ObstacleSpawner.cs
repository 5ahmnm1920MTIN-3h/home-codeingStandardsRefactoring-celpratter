﻿using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public static ObstacleSpawner instance;
    public GameObject[] obstacles;
    public bool gameOver = false;
    public float minSpawnTime, maxSpawnTime;
    private string spawnCoroutine = "Spawn";
    private float defaultWaitTime = 1f;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(spawnCoroutine);
    }
    IEnumerator Spawn()
    {
        float waitTime = defaultWaitTime;
        yield return new WaitForSeconds(waitTime);
        while (!gameOver)
        {
            SpawnObstacle();
            waitTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(waitTime);
        }
    }
    private void SpawnObstacle()
    {
        int random = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[random], transform.position, Quaternion.identity);
    }
}
