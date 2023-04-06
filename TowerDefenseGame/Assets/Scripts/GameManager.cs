using UnityEngine;
using System.Collections;
using System.Collections.Generic;


// modified on 20/18/2023
// Inheriting from the singleton class to create and unique instance
// modified on 02/25/2023 the GameManager class is going to be the player observer, to keep track of the player lives
public class GameManager : Singleton<GameManager>, IObserverLives
{
    public static bool GameIsOver;

    public GameObject gameOverUI;
    public GameObject completeLevelUI;

    // This is the player stats class which is going to be observed by the game manager
    private PlayerStats playerStats;

    void Start()
    {
        GameIsOver = false;

        // This is to find the Player in game and get the player stats script
        playerStats = GameObject.FindObjectOfType<PlayerStats>();
    }


    // this is where the player stats being updated
    public void UpdateLives(int aLives)
    {
        playerStats.Lives = aLives;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsOver)
            return;

        // this is to check if the player has no more lives
        if (playerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }

   
}
