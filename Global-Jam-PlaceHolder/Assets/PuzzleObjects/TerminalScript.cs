using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalScript : MonoBehaviour
{
    public Camera cam;
    public GameObject terminalScreen;
    public int x;
    public int y;

    private void Start()
    {
        cam = GameObject.Find("Topdown Camera").GetComponent<Camera>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // if (Input.GetKeyDown(KeyCode.E))
        //{
        cam = GameObject.Find("Topdown Camera").GetComponent<Camera>();
        cam.transform.position = new Vector3(x, y, -10);
       // }
    }

}
