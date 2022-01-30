using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //public void Retry()
    //{
    //    Debug.Log(SceneManager.GetActiveScene().buildIndex);
    //}

    
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
