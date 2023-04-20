using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeAsteroid : Asteroid
{
    private Rigidbody2D rb;


    private void Start()
    {
        SetSpeed();
        rb = GetComponent<Rigidbody2D>();
    }


    public override float Speed
    {
        get
        {
            return 2.5f;
        }
    }

    public override float RotationSpeed
    {
        get
        {
            return 6.0f;
        }
    }


    public void SetSpeed()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = -transform.right * Speed;
    }

    public void SetRotate()
    {
        if (rb != null)
        {
            rb.transform.Rotate(0f, 0f, 3.0f * RotationSpeed * Time.deltaTime, Space.Self);
        }
    }


    // Update is called once per frame
    void Update()
    {
        SetRotate();
    }
}
