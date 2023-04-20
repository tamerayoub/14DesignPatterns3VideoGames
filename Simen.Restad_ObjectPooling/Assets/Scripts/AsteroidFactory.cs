using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidFactory : MonoBehaviour
{
    [SerializeField] GameObject[] asteroidPrefab;
    [SerializeField] float smallAsteroidInterval = 3.0f;
    [SerializeField] float mediumAsteroidInterval = 5.0f;
    [SerializeField] float largeAsteroidInterval = 9.0f;
    [SerializeField] float minTras = -3.5f;
    [SerializeField] float maxTras = 4.0f;


    void Start()
    {
        StartCoroutine(AsteroidSpawn(asteroidPrefab[0], smallAsteroidInterval));
        StartCoroutine(AsteroidSpawn(asteroidPrefab[1], mediumAsteroidInterval));
        StartCoroutine(AsteroidSpawn(asteroidPrefab[2], largeAsteroidInterval));
    }

    IEnumerator AsteroidSpawn(GameObject prefab, float seconds)
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(transform.position.x, wanted);
            yield return new WaitForSeconds(seconds);
            GameObject gameObject = Instantiate(prefab, position, Quaternion.identity);
            Destroy(gameObject, 10f);
        }
    }
}
