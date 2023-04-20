using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// this script is attached to the bullet prefabs and laser prefabs
public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;



    public void SetSpeed(int addSpeed)
    {
        speed = addSpeed;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }


    private void OnBecameInvisible()
    {
        //Destroy(gameObject);

        gameObject.SetActive(false);
    }
}
