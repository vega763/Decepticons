using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapons : MonoBehaviour
{

    public GameObject barrel;
    public LaserSiteControl LzrSight;
    public float speed;
    public float angle;

    public UFOController myUFO;
    public LinkMovementControll myLink;
    public GameObject projectile;
    // use this for initialization
    public bool isLink;
    void Start() {

       
            myUFO = GetComponent<UFOController>();
        myLink = GetComponent<LinkMovementControll>();



    }


    // Update is called once per frame
    void Update()
    {

        ShootProjectile();
    }

    public void ShootProjectile()
    {
        //Rotate Laser
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        barrel.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //Set laser endpoint
        dir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dir.z = 0f;
        LzrSight.SetEnd(dir);
        //toggle laser 
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown (KeyCode.Z))
        {

            LzrSight.ToggleLaser();
        }
        //Shoot projectile
        if(Input.GetMouseButtonDown(0))
        {
            dir = Input.mousePosition  - Camera.main.WorldToScreenPoint(transform.position);
            angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

            barrel.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            Instantiate(projectile, transform.position, barrel.transform.rotation);
        }
    }

}
