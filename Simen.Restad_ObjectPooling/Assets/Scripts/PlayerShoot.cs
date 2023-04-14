using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// Modified by Tamer Ayoub 4/1/2023; Added right click functionality to shoot lasers (Adapter pattern)
public class PlayerShoot : MonoBehaviour
{

    public Transform shootingPoint;
    public GameObject bulletPrefab;
    public GameObject laserPrefab; // our laser we will adapt/mod our object pool/gun to shoot

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) // this is the original if statement that only checked for left click, I added a right click if statement below for adaptability 
        {
            GameObject bullet = ObjectPool.instance.GetPooledObject(); 
            Debug.Log("Hit left");
            if (bullet != null)
            {
                bullet.transform.position = shootingPoint.position;
                bullet.transform.rotation = shootingPoint.rotation;
                bullet.SetActive(true);
                bullet.GetComponent<Bullet>().SetSpeed();
            }

        }
        if (Mouse.current.rightButton.wasPressedThisFrame) // here we added our right click functionality that calls our Adapted Object Pool Class w/ a Right Click parameter
        {
            GameObject laser = ObjectPoolAdapter.instance1.GetPooledObject(Click.RightClick);
            Debug.Log("Hit right");
            if (laser != null)
            {
                laser.transform.position = shootingPoint.position;
                laser.transform.rotation = shootingPoint.rotation;
                laser.SetActive(true);
                laser.GetComponent<Bullet>().SetSpeed();
            }
        }
    }
}
