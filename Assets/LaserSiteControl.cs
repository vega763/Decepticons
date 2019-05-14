using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSiteControl : MonoBehaviour
{
    public LineRenderer myline;
    public Vector3 startpoint;
    public Vector3 stopPoint;
    public bool laserOn;
    // Start is called before the first frame update
    void Start()
    {
        myline = GetComponent<LineRenderer>();
    }
   
   
    // Update is called once per frame
    void Update()
    {
        myline.SetPosition(0, transform.position);
        myline.SetPosition(1, stopPoint);
    }

    public void SetStart(Vector3 point)
    {
        startpoint = point;
    }

    public void SetEnd(Vector3 point)
    {
        stopPoint = point;
    }
    public void ToggleLaser()
    {
        laserOn = !laserOn;
    }
}
