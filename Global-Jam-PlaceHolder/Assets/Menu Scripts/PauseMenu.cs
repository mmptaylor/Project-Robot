using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUi;

    public GameObject pauseCamera;

    public GameObject mainCamera;

    public GameObject topDownCamera;

    private void Start()
    {
        Time.timeScale = 1.0f;
        GameIsPaused = true;
    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        pauseMenuUi.SetActive(false);
        pauseCamera.SetActive(false);
        mainCamera.SetActive(true);
        topDownCamera.SetActive(true);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUi.SetActive(true);
        pauseCamera.SetActive(true);
        mainCamera.SetActive(false);
        topDownCamera.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameIsPaused = true;
    }

    public void ResumeButton()
    {
        Time.timeScale = 1.0f;
        GameIsPaused = false;
        mainCamera.SetActive(true);
        topDownCamera.SetActive(true);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    public void QuitButton()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
