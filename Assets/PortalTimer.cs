using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTimer : MonoBehaviour
{

    public Transform portalrest;
    public float timeToMove;
    public float myTimer;
    public bool isCounting;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            timeToMove -= Time.deltaTime;
        }
        if (timeToMove <= 0)
        {
            //Destroy(gameObject);
            gameObject.transform.position = portalrest.position;
            isCounting = false;
            timeToMove = myTimer;

        }
    }

}
