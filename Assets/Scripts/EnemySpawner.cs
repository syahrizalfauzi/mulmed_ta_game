using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy1;
    [SerializeField] GameObject enemy2;
    [SerializeField] Transform enemySpawner1;
    [SerializeField] Transform enemySpawner2;

    [SerializeField] float spawnInterval = 2f;
    [SerializeField] float spawnRandomOffset = 1f;

    float nextSpawn = 0f;

    void Start()
    {
        nextSpawn = spawnInterval;
    }

    void Update()
    {
        if (Time.time >= nextSpawn)
        {
            nextSpawn = Time.time + Random.Range(spawnInterval - spawnRandomOffset, spawnInterval + spawnRandomOffset);
            bool isSpawningEnemy1 = Random.value <= 0.5f;
            if (isSpawningEnemy1)
            {
                Instantiate(enemy1, enemySpawner1.position, enemySpawner1.rotation);
            }
            else
            {
                Instantiate(enemy2, enemySpawner2.position, enemySpawner2.rotation);
            }
        }
    }
}
