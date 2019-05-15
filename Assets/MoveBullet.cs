﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D theRB2D;
    public int bulletDamage;

    // Start is called before the first frame update
    void Start()
    {
        theRB2D = GetComponent<Rigidbody2D>();

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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyHealthController>().TakeDamage(bulletDamage);
            Destroy(gameObject);
        }
        else if(other.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
}
