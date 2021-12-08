using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    
    void Start()
    {
        
    }

 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpawPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(enemyPrefabs[0], spawnPoints[randSpawPoint].position, transform.rotation);
        }
    }
}
