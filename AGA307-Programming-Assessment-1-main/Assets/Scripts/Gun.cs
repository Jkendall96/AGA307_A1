using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("Components and References")]
    public Projectile prefab;
    public Transform spawnPosition;

    public void Shoot()
    {

        Instantiate(prefab, spawnPosition.position, spawnPosition.rotation);
    }



}
