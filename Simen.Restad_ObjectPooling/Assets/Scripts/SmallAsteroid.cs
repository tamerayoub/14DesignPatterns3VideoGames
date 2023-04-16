using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallAsteroid : Asteroid
{
    private Rigidbody2D rb;

    [SerializeField] GameObject[] asteroidPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    public SmallAsteroid()
    {
        rb = new Rigidbody2D();
    }

    public override float Speed
    {
        get
        {
            return 4.0f;
        }
    }

    public override float RotationSpeed
    {
        get
        {
            return 10.0f;
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
            gameObject.GetComponent<SmallAsteroid>().SetSpeed();
            Destroy(gameObject, 10f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        SetRotate();
    }
}
