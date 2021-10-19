using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] targetTypes;
    public List<GameObject> Targets;
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("I"))
            SpawnTarget();

    }
    void SpawnTarget()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            int rNum = Random.Range(0, targetTypes.Length);
            GameObject enemies = Instantiate(targetTypes[rNum], spawnPoints[i].position, spawnPoints[i].rotation);
        }
    }
}
