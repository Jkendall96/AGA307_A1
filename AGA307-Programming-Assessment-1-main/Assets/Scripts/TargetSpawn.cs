using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] targetTypes;
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            SpawnTarget();

    }
    void SpawnTarget()
    {
        int rTarget = Random.Range(0, targetTypes.Length);
        int rSpawn = Random.Range(0, spawnPoints.Length);
        Instantiate(targetTypes[rTarget], spawnPoints[rSpawn].position, Quaternion.identity);
    }
}
