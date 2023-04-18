using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class FullyAutoBullet : BulletDecorator
{
    // Update is called once per frame
    public void Update()
    {
        // this is the original if statement that only checked for left click, I added a right click if statement below for adaptability
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {



            GameObject bullet = ObjectPool.instance.GetPooledObject();
            Debug.Log("Hit left");
            if (bullet != null)
            {
                if (Input.GetKeyDown(KeyCode.V))
                {
                    bullet.transform.position = shootingPoint.position;
                    bullet.transform.rotation = shootingPoint.rotation;
                    bullet.SetActive(true);
                    bullet.GetComponent<Bullet>().SetSpeed(100);
                }
                else
                {
                    bullet.transform.position = shootingPoint.position;
                    bullet.transform.rotation = shootingPoint.rotation;
                    bullet.SetActive(true);
                    bullet.GetComponent<Bullet>().SetSpeed(10);
                }
            }
        }
        // here we added our right click functionality that calls our Adapted Object Pool Class w/ a Right Click parameter
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            GameObject bullet = ObjectPool.instance.GetPooledObject();
            Debug.Log("Hit left");
            if (bullet != null)
            {
                if (Input.GetKeyDown(KeyCode.V))
                {
                    bullet.transform.position = shootingPoint.position;
                    bullet.transform.rotation = shootingPoint.rotation;
                    bullet.SetActive(true);
                    bullet.GetComponent<Bullet>().SetSpeed(100);
                }
                else
                {
                    bullet.transform.position = shootingPoint.position;
                    bullet.transform.rotation = shootingPoint.rotation;
                    bullet.SetActive(true);
                    bullet.GetComponent<Bullet>().SetSpeed(10);
                }
            }
        }
    }
}
