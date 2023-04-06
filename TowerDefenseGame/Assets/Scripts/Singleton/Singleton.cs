// created by Qusai Fannoun
//02/18/2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// The singleton class
public class Singleton<T> : MonoBehaviour where T : Component
{
    public static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();
                if (instance == null)
                {
                    GameObject anObject = new GameObject();
                    anObject.name = typeof(T).Name;
                    instance = anObject.AddComponent<T>();
                }
            }
            return instance;
        }
    }

    public virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}

// The Build Manager and the Game Manager classes are inheriting the singleton class