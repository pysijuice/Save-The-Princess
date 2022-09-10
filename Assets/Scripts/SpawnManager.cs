using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] spawnPositions;
    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] float spawnTimer;
    [SerializeField] float spawnDelay;
    private int numberOfSpawnPositions;

    private void Start()
    {
        numberOfSpawnPositions = spawnPositions.Length;
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true) 
        {
            yield return new WaitForSeconds(spawnTimer);
            int randomEnemy = Random.Range(0, 1);
            int randomSpawn = Random.Range(0, numberOfSpawnPositions);
            spawnTimer -= spawnDelay;
            Instantiate(enemyPrefabs[randomEnemy], spawnPositions[randomSpawn].transform.position, Quaternion.identity);
        }
        

    }
}
