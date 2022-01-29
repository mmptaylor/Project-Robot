using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    bool switchS = false;
    public GameObject Activates;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D other)
    {

        switchS = !switchS;
        Activates.SetActive(switchS);
    }
}
