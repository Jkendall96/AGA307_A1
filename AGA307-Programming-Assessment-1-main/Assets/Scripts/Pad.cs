using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{


    public GameObject sphere;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sphere.GetComponent<Renderer>().material.color = Color.green;
        }

    }

     void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sphere.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
