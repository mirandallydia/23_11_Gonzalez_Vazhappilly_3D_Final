using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E)) 
        {
            if(GameIsPaused) 
            {
                Resume();

            } else
            {
                Pause();
            }
        }
    }

    void Resume() 
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; 
        GameIsPaused = true;
    }

    public void MenuButton()
    {
        Debug.Log("loading menu...");
        SceneManager.LoadScene(0);
        //SceneManager.LoadScene("SCENENAME"); OR SceneManager.LoadScene(BUILD INDEX NUMBER);


    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
