using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGunControll : MonoBehaviour
{
    public GameObject barrel;
    //public LaserSiteControll lzrSight;
    public float speed;
    public float angle;

    public UFOController myUFO;
    public LinkMovementControll myLink;
    public GameObject portalOrb_A;
    public GameObject portalOrb_B;

    public int portalCount;

    // Use this for initialization
    void Start()
    {
        myUFO = GetComponent<UFOController>();
        myLink = GetComponent<LinkMovementControll>();
    }

    // Update is called once per frame
    void Update()
    {
        ShootportalOrb();
    }

    public void ShootportalOrb()
    {
        //Shoot portalOrb
        if (Input.GetKeyDown(KeyCode.R))
        {

            if (portalCount == 0)
            {
                Debug.Log("Portal A");
                Instantiate(portalOrb_A, transform.position, barrel.transform.rotation);
                portalCount++;
                if (portalCount > 1)
                {
                    portalCount = 0;
                }
            }
            else if (portalCount == 1)
            {
                Debug.Log("Portal B");
                Instantiate(portalOrb_B, transform.position, barrel.transform.rotation);
                portalCount++;
                if (portalCount > 1)
                {
                    portalCount = 0;
                }
            }
        }
    }

}
