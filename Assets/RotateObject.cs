using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotatespeed;
    public bool allowRotate; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (allowRotate)
        {
            transform.Rotate(Vector3.forward, rotatespeed * Time.deltaTime, Space.World);
        }




    }
}
