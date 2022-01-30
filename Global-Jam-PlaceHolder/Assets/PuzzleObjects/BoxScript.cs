using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{

    bool isGrabbed;

    // Start is called before the first frame update
    void Start()
    {
        isGrabbed = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.name == "Player")
        {
            if (Input.GetKey(KeyCode.W))
            {
                isGrabbed = true;
            }
            if (Input.GetKey(KeyCode.S))
            {
                isGrabbed = false;
            }
            if (isGrabbed)
            {
                transform.position = other.transform.position;
            }
        }

    }
}
