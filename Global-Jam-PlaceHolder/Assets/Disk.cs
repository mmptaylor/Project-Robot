using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour
{
    public GameObject terminal;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "PlayerAI")
        {
            terminal.GetComponent<TerminalScript>().safeFlag = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "PlayerAI")
        {
            terminal.GetComponent<TerminalScript>().safeFlag = false;
        }
    }
}
