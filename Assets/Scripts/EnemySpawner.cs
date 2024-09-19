using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  
    public Transform spawnPoint;  
    private GameObject spawnedEnemy;  
   
    private GameObject mario; 

    private bool enemySpawned = false;

    private void Start()
    {
        
        mario = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player") && !enemySpawned)
        {
            SpawnEnemy();
            enemySpawned = true;
        }
    }

    void SpawnEnemy()
    {
        
        spawnedEnemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }

    
}
