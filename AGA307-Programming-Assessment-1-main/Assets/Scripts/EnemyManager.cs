using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyTypes;
    public List<GameObject> enemies;

    private void Start()
    {
        for(int i = 0; i < 101; i++)
        {
            print(i);
        }
        SpawnEnemy();
    }


    void SpawnEnemy()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            int rNum = Random.Range(0, enemyTypes.Length);
            GameObject enemies = Instantiate(enemyTypes[rNum], spawnPoints[i].position, spawnPoints[i].rotation);
            
        }
    }

}
