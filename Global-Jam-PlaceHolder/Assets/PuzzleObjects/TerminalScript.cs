using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalScript : MonoBehaviour
{
    public Camera cam;
    public GameObject terminalScreen;
    public int x;
    public int y;
    public bool safeFlag;
    private string nameVar;
    bool clickFlag;

    private void Start()
    {
        cam = GameObject.Find("Topdown Camera").GetComponent<Camera>();
        clickFlag = false;
        safeFlag = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {


            if (clickFlag && GameObject.Find("Player").GetComponent<PlayerController>().hasAI == true )
            {
                print("floppyIn");
                cam = GameObject.Find("Topdown Camera").GetComponent<Camera>();
               // cam.transform.position = new Vector3(x, y, -10);
                GameObject.Find("Player").GetComponent<PlayerController>().hasAI = false;
                GameObject.Find("Player").GetComponent<PlayerController>().pcAI = gameObject.name;
                clickFlag = false;
            }
            else if (clickFlag && GameObject.Find("Player").GetComponent<PlayerController>().hasAI == false && GameObject.Find("Player").GetComponent<PlayerController>().pcAI == gameObject.name)
            {
                print("floppyOut");
                GameObject.Find("Player").GetComponent<PlayerController>().hasAI = true;
                GameObject.Find("Player").GetComponent<PlayerController>().pcAI = "empty";
                clickFlag = false;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            clickFlag = true;
            //print("click");
        }
        else
        {
            clickFlag = false;
        }

    }

}
