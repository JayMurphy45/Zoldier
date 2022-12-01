using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Variables
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;


    //Methods
    void Start()
    {
        SpawnNewEnemy();
    }



    void SpawnNewEnemy()
    {
        Instantiate(enemyPrefab, spawnPoints[0].transform.position, Quaternion.identity);
    }
}
