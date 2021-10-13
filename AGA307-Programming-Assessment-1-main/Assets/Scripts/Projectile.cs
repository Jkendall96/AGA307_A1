using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [Header("Settings")]
    public float speed = 10;
    [Header("Components")]
    public Rigidbody RB;
    public float lifeTime = 10f;




    // Start is called before the first frame update
    void Start()
    {
        RB = this.GetComponent<Rigidbody>();
        RB.velocity = transform.forward * speed;
        Destroy(this.gameObject, lifeTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);


        if(collision.gameObject.tag =="Target")
        Destroy(collision.gameObject, 1);
    }
   private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        if(other.gameObject.tag == "Target")
        {
            Destroy(other.gameObject);
        }
    }
}
