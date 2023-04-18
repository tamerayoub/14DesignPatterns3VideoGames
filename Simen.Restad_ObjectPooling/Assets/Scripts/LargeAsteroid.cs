//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeAsteroid : Asteroid
{
    private Rigidbody2D rb;

    [SerializeField] GameObject[] asteroidPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    public LargeAsteroid()
    {
        rb = new Rigidbody2D();
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
        rb.transform.Rotate(0f, 0f, 3.0f * RotationSpeed * Time.deltaTime, Space.Self);
    }

    void Start()
    {
        StartCoroutine(AsteroidSpawn());
    }

    IEnumerator AsteroidSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(transform.position.x, wanted);
            GameObject gameObject = Instantiate(asteroidPrefab[Random.Range(0, asteroidPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            gameObject.GetComponent<LargeAsteroid>().SetSpeed();
            Destroy(gameObject, 10f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        SetRotate();
    }
}
