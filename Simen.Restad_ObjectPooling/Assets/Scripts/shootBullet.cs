using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shootBullet : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    public GameObject laserPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);

            GameObject bullet = Pool.instance.GetPooledObject();

            if (bullet != null)
            {
                bullet.transform.position = shootingPoint.position;
                bullet.transform.rotation = shootingPoint.rotation;
                bullet.SetActive(true);
                bullet.GetComponent<BulletSpeed>().SetSpeed();
            }
        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            //Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);

            GameObject laser = Pool.instance.GetPooledObject();

            if (laser != null)
            {
                laser.transform.position = shootingPoint.position;
                laser.transform.rotation = shootingPoint.rotation;
                laser.SetActive(true);
                laser.GetComponent<BulletSpeed>().SetSpeed();
            }
        }
    }
}
