using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerminalScript : MonoBehaviour
{
    public Camera cam;
    public GameObject terminalScreen;
    //public int x;
    //public int y;
    private string nameVar;
    bool clickFlag;

    private void Start()
    {
        cam = GameObject.Find("Topdown Camera").GetComponent<Camera>();
        clickFlag = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {


            if (clickFlag && GameObject.Find("Player").GetComponent<PlayerController>().hasAI == true )
            {
                print("floppyIn");
                cam = GameObject.Find("Topdown Camera").GetComponent<Camera>();
                //cam.transform.Translate(0, 0, -10);
                GameObject.Find("Player").GetComponent<PlayerController>().hasAI = false;
                //GameObject.Find("Player").GetComponent<PlayerController>().pcAI = gameObject.name;
                GameObject.Find("PlayerAI").GetComponent<PlayerControllerAI>().isLoaded = true;
                clickFlag = false;
            }
            else if (clickFlag && GameObject.Find("Player").GetComponent<PlayerController>().hasAI == false) //&& GameObject.Find("Player").GetComponent<PlayerController>().pcAI == gameObject.name)
            {
                print("floppyOut");
                if (GameObject.Find("PlayerAI").GetComponent<PlayerControllerAI>().safeFlag)
                {
                    //cam.transform.Translate(0, 0, -10);
                    GameObject.Find("Player").GetComponent<PlayerController>().hasAI = true;
                    GameObject.Find("Player").GetComponent<PlayerController>().pcAI = "empty";
                    GameObject.Find("PlayerAI").GetComponent<PlayerControllerAI>().isLoaded = false;
                    clickFlag = false;
                }
                else
                {
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
