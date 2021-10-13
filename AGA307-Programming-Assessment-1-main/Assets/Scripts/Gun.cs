using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public bool useHitScan = false;
    [Header("Components and References")]
    public Projectile prefab;
    public Transform spawnPosition;

    public LayerMask hitMask;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Shoot();
    }

    public void Shoot()
    {

        if(useHitScan)
        {
            Ray r = new Ray(spawnPosition.position, spawnPosition.forward);
            RaycastHit h;

            if(Physics.Raycast(r, out h, 10, hitMask))
            {
                Debug.DrawLine(r.origin, h.point, Color.green, 0.125f);
            }
            else
            {
                Debug.DrawRay(r.origin, r.direction * 10, Color.red, 0.125f);
            }
        }

        else
            Instantiate(prefab, spawnPosition.position, spawnPosition.rotation);
    }



}
