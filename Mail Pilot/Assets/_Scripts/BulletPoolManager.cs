﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public static BulletPoolManager SharedInstance;

    void Awake()
    {
        SharedInstance = this;
    }

    //TODO: create a structure to contain a collection of bullets
    GameObject bullet;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;
    public Boundary boundary;
    public BulletPoolManager resetObj;





    // Start is called before the first frame update
    void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);

        }
        

        // TODO: add a series of bullets to the Bullet Pool
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool

    public GameObject GetBullet()
    {
        //Iterate through pooled objects
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            //Check to see if bullet is active in scene. If it is, move to next bullet
            if (!pooledObjects[i].activeInHierarchy)
            {
            //    GameObject tempObj;
                return pooledObjects[i];
            }
            
        }
        //if everything is active return nothing
        return null;
    }




    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {

        //if (transform.position.y >= boundary.Top)
        //{

        //    if (gameObject.tag == "Bullet")
        //    {
        //        gameObject.SetActive(false);
        //        pooledObjects.Add(bullet);
        //    }
        //    // if its not a bullet just destroy it 
        //    else
        //    {
        //        Destroy(gameObject);
        //    }
        //}

    }
}
