
// modified on 02/25/2023 the one of the classes that will subscribe to the GameManger to keep track of the player lives
using UnityEngine;
using UnityEngine.UI;

// one of our observers for the observer pattern 
public class LivesUI : MonoBehaviour
{

    public Text livesText;


    private PlayerStats playerStats;
    GameManager aLivesObserver;

    private void Start()
    {
        aLivesObserver = GameObject.FindObjectOfType<GameManager>();
        playerStats = GameObject.FindObjectOfType<PlayerStats>();

        playerStats.Subscribe(aLivesObserver);
        // subscribe to our subject
    }

    // Update is called once per frame
    void Update()
    {
		// Observe how many lives we have from our Observeable Player stats and Display
        livesText.text = playerStats.Display();
    }
}
