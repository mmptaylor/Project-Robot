using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownButton : MonoBehaviour
{

    bool switchS = false;
    public GameObject Activates;

    private void OnTriggerEnter2D(Collider2D other)
    {

        switchS = !Activates.activeSelf;
        Activates.SetActive(switchS);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        switchS = !Activates.activeSelf;
        Activates.SetActive(switchS);
    }
}
