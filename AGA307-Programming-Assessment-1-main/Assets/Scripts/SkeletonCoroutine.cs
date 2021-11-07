using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonCoroutine : MonoBehaviour
{
    float moveDistance = 500f;
   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
    }
    IEnumerator Move()
    {
        for (int i = 0; i < moveDistance; i++)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            yield return null;
            yield return new WaitForSeconds(3);

        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Move());
        }
    }

    
}
