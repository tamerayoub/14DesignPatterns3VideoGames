using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public GameObject ui;

	public string menuSceneName = "MainMenu";

	public SceneFader sceneFader;

	/*void Start () 
	{
        StartCoroutine(CheckPauseMenuCoroutine()); // we need this StartCoroutine to start the function CheckPauseMenuCoroutine()e where we apply the Coroutine pattern
    }*/

	void Update ()
	{

        StartCoroutine(CheckPauseMenuCoroutine());

        /*if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
		{
			Toggle();
		}*/
    }

    // I applied the Coroutine pattern here which helps us not have to continously render every frame and instead wait a certain amount of time before checking to pause the menu
    IEnumerator CheckPauseMenuCoroutine()
	{
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))

        {
            Toggle();

        }

        yield return new WaitForSeconds(2f);
        // wait ..... seconds before checking where the closest enemies are, instead of running every frame
    }


    public void Toggle ()
	{
		ui.SetActive(!ui.activeSelf);

		if (ui.activeSelf)
		{
			Time.timeScale = 0f;
		} else
		{
			Time.timeScale = 1f;
		}
	}

	public void Retry ()
	{
		Toggle();
		sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }

	public void Menu ()
	{
		Toggle();
		sceneFader.FadeTo(menuSceneName);
	}

}
