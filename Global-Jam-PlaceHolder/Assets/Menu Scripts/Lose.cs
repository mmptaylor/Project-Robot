using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Lose : MonoBehaviour

{
    int retryLevel;

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Retry()
    {
        //retryLevel = GameObject.Find("Terminal(1)").GetComponent<TerminalScript>().previousLevel;
        //SceneManager.LoadScene(retryLevel);
        //Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }


    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
