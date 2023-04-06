
// Modified on 02/25/2023 the ENEMY class will notify the observer with the amount of lives that the player has
// because it will decrease the number of lives whenever the enemy reach the player base. 
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour
{

    private Transform target;
    private int wavepointIndex = 0;

    GameManager aLivesObserver;


    private PlayerStats playerStats;
    private Enemy enemy;

    void Start()
    {
        enemy = GetComponent<Enemy>();

        target = Waypoints.points[0];

        aLivesObserver = GameObject.FindObjectOfType<GameManager>();
        playerStats = GameObject.FindObjectOfType<PlayerStats>();

        playerStats.Subscribe(aLivesObserver);
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemy.speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }

        enemy.speed = enemy.startSpeed;
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

    void EndPath()
    {
        // Notifying the GameManager with the number of lives
        playerStats.Notify(playerStats.Lives--);
        Debug.Log($"Player Stats: " + playerStats.Lives);

        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }

}
