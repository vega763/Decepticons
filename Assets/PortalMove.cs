using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMove : MonoBehaviour
{

    public bool isPortalA;
    public GameObject portalA;
    public GameObject portalB;
    public float movementSpeed;

    public Rigidbody2D theRB2D;

    public GameObject soundSpawn;
    // Use this for initialization
    void Start()
    {
        theRB2D = GetComponent<Rigidbody2D>();
        portalA = GameObject.Find("PortalA");
        portalB = GameObject.Find("PortalB");
    }

    // Update is called once per frame
    void Update()
    {
        theRB2D.velocity = transform.right * movementSpeed;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            //other.GetComponent<EnemyHealthController>().TakeDamage(bulletDamage);
            //Instantiate(soundSpawn, transform.position, transform.rotation);
            if (isPortalA)
            {
                portalA.transform.position = gameObject.transform.position;
                portalA.GetComponent<PortalTimer>().isCounting = true;
            }
            else
            {
                portalB.transform.position = gameObject.transform.position;
                portalB.GetComponent<PortalTimer>().isCounting = true;
            }
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            //Damage Player
            //Destroy(gameObject);
        }

    }

}
