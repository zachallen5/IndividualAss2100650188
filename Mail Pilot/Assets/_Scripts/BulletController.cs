﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class BulletController : MonoBehaviour
{
    public float bulletSpeed = 0.1f;
    public Boundary boundary;

    //TODO: create a reference to the BulletPoolManager

    void Start()
    {
        boundary.Top = 2.45f;
    }


    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    private void Move()
    {
        transform.position += new Vector3(0.0f, bulletSpeed, 0.0f);
    }
    //Destroys bullet when off screen
    private void CheckBounds()
    {
        if (transform.position.y >= boundary.Top)
        {

                if (gameObject.tag == "Bullet")
                {
                    gameObject.SetActive(false);
                }
                else
                {
                    Destroy(gameObject);
                }
            



            //TODO: This code needs to change to use the BulletPoolManager's
            //TODO: ResetBullet function which will return the bullet to the pool
            //    Destroy(this.gameObject);
        }
    }
}
