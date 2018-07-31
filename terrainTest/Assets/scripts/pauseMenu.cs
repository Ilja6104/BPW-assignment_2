using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;

	void Update () {
	
        
       if( Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused == false)
            {
                Pause();
                Debug.Log("clicked");
            }
            else
            {
                Resume();
                Debug.Log("clicked2");
            }

         }




	}

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        gameIsPaused = true;
        Time.timeScale = 0f;
        Debug.Log("paused");
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        gameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void toMainMenu()
    {
        gameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }


    public void quitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
