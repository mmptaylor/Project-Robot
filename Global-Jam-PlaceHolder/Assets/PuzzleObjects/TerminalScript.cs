using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerminalScript : MonoBehaviour
{
    public Camera cam;
    public GameObject terminalScreen;
    public Animator anime;
    //public int x;
    //public int y;

    private string nameVar;
    bool clickFlag;
    


    private void Start()
    {
        cam = GameObject.Find("Topdown Camera").GetComponent<Camera>();
        anime = GetComponent<Animator>();
        clickFlag = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {


            if (clickFlag && GameObject.Find("Player").GetComponent<PlayerController>().hasAI == true )
            {
                print("floppyIn");
                anime.SetBool("OnOff", true);
                cam = GameObject.Find("Topdown Camera").GetComponent<Camera>();
                GameObject.Find("Player").GetComponent<PlayerController>().hasAI = false;

            }
            else if (clickFlag && GameObject.Find("Player").GetComponent<PlayerController>().hasAI == false)
            {
                print("floppyOut");
                anime.SetBool("OnOff", false);
                if (GameObject.Find("PlayerAI").GetComponent<PlayerControllerAI>().safeFlag)
                {
                    GameObject.Find("Player").GetComponent<PlayerController>().hasAI = true;

                }
                else
                {
                    //GameObject.Find("LoseOverlay").SetActive(true);
                    //GameObject.Find("MainCamera").SetActive(false);
                    //GameObject.Find("TopDownCamera").SetActive(false);
                    //GameObject.Find("Lose Menu").SetActive(true);
                    //GameObject.Find("Lose Camera").SetActive(true);
                    
                    //mainCamera.SetActive(false);
                    //topDownCamera.SetActive(false);
                    //Time.timeScale = 0f;                   
                    //GameManager.previousLevel = SceneManager.GetActiveScene().buildIndex;
                    //print(previousLevel);
                    //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Lose"));
                    SceneManager.LoadScene("Lose");

                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            clickFlag = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            clickFlag = false;
        }
    }
}
