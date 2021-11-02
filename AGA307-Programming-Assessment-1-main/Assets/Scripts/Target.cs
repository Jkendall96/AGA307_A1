using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TargetSize
{
    Thic,
    Thicc,
    Thiccc
}


public class Target : MonoBehaviour
{
    [Header("Size")]
    public TargetSize thiccness;
    public float[] sizes = new float[]
    {
        0.5f,
        1,
        2
    };


    [Header("Movement")]
    public int[] speeds = new int[]
    {
        1,
        2,
        3
    };
    public int strafeDistance = 3;
    Vector3 centre;
    private void Start()
    {
        centre = this.transform.position;
        SetTargetSize();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if(Input.GetKeyDown(KeyCode.R))
        {
            thiccness = (TargetSize)(int)Random.Range(0, 3);
            SetTargetSize();
        }
    }

    private void Move()
    {
        Vector3 targetPos = centre + (Vector3.left * strafeDistance);
        if (this.transform.position != targetPos)

            this.transform.position = Vector3.MoveTowards(this.transform.position, targetPos, speeds[(int)thiccness] * Time.deltaTime);
        else
            strafeDistance *= -1;
    }
    void SetTargetSize()
    {
        int enumAsInt = (int) thiccness;
        float scaleFactor = sizes[enumAsInt];

        /*
         switch (thiccness)
        {
            case TargetSize.Thic:
                scaleFactor = 0.5f;
                break;
            case TargetSize.Thicc:
                scaleFactor = 1;
                break;
            case TargetSize.Thiccc:
                scaleFactor = 2f;
                break;
               
        }
         */
        this.transform.localScale = Vector3.one * sizes[(int)thiccness];
        
    }
}
