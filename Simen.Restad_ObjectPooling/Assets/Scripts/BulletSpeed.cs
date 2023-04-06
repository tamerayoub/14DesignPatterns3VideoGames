using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    public void SetSpeed()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        
    }

    private void OnBecameInvisible()
    {
        //Destroy(gameObject);

        gameObject.SetActive(false);
    }
}
