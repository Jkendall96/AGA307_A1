using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("Legen-, wait for it...");
        yield return new WaitForSeconds(1);
        Debug.Log("dary");
    }
}
