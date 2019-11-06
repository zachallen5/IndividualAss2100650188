using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class BulletController : MonoBehaviour
{
    public GameObject bullet;

    public float bulletSpeed = 0.1f;
    public Boundary boundary;
    public bool isFiring = false;

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
        isFiring = true;
        
    }
    //Destroys bullet when off screen
    private void CheckBounds()
    {
        if (transform.position.y >= boundary.Top)
        {
            //check if the object that exceeded the screen is a bullet. if it is make it not active


            if (gameObject.tag == "Bullet")
            {
                gameObject.SetActive(false);
            }
            // if its not a bullet just destroy it 
            else
            {
                Destroy(gameObject);
            }


        }



        //TODO: This code needs to change to use the BulletPoolManager's
        //TODO: ResetBullet function which will return the bullet to the pool
        //    Destroy(this.gameObject);

    }
}
