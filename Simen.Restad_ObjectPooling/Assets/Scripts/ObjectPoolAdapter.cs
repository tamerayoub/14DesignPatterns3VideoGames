using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using System.IO;
using System; // Modified by Tamer Ayoub 4/1/2023; This is the new adapted object pooling class.
public class ObjectPoolAdapter : ObjectPool, IObjectPool
{

    public static ObjectPoolAdapter instance1;

    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amountToPool = 20;


    [SerializeField] private GameObject laserPrefab; // our new laser option
    private void Awake()
    {
        if (instance1 == null)
        {
            instance1 = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj2 = Instantiate(laserPrefab);
            obj2.SetActive(false);
            pooledObjects.Add(obj2);
        }
    }

    public GameObject GetPooledObject(Click click) // our new adapted GetPooledObject method, this is able to check if we right clicked and if we did, it will create an object pool just for lasers
    {
        if (click == Click.RightClick)
        {
            for (int i = 0; i < pooledObjects.Count; i++)
            {
                if (!pooledObjects[i].activeInHierarchy)
                {
                    return pooledObjects[i];
                }
            }

            return null;
        }
        else
        {
            // Throw an exception if there are no objects available in the pool
            throw new InvalidOperationException("Object pool is empty.");
        }

    }
}