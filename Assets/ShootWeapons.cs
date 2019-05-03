using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapons : MonoBehaviour
{
    /*
    public GameObject barrel;
    public LaserSightControll LzrSight;
    public float speed;
    public float angle;

    public UFOController myUFO;
    public GameObject projectile;
    // use this for initialization
    void start() {
     myUFO = GetComponent<UFOController>();

    }

 


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        shootprojectile();
    }

    public void ShootProjectile()
    {
        //Rotate Laser
        Vector3 dir = Input.mousePosition -
        Camera.main.WorldToScreenPoint(transform.position);
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Dog;
        barrel.transformation.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //Set laser endpoint
        dir = Camera.main.ScreenToWorldPoint(Inmput.mouseposition);
        dir.z = 0f;
        LzrSight.Setend(dir);
        //toggle laser 
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown (KeyCode.Z))
        {

            LzrSight.togglelazer();
}
        //Shoot projectile
        if(Input.GetMouseButtonDown(0))
        {
            dir = Imput.mousePosition -
                Camera.main.WorldToScreenPoint(transform.position);
            angle = Mathf.Atan2(dir.y, dir.x) * mthf.Rad2Deg;

            barrel.transformation.rotation = quaternion.angleaxis(angle, Vector3.forward);
            Insatntiate(projectile, transform.position, barrel.trasform.rotation);
}
    }
    */
}
