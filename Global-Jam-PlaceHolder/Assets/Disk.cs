using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "PlayerAI")
        {
            GameObject.Find("PlayerAI").GetComponent<PlayerControllerAI>().safeFlag = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "PlayerAI")
        {
            GameObject.Find("PlayerAI").GetComponent<PlayerControllerAI>().safeFlag = false;
        }
    }
}
