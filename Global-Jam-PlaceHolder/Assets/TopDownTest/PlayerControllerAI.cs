using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerAI : MonoBehaviour
{
    bool ctrlFlag;
    public bool isLoaded;
    public bool safeFlag;
    // Start is called before the first frame update
    void Start()
    {
        ctrlFlag = false;
        safeFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
            ctrlFlag = !ctrlFlag;

        if (ctrlFlag && isLoaded)
        {
            int layerMask = LayerMask.GetMask("Platform");



            if (Input.GetKeyDown(KeyCode.A))
            {
                RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position + new Vector3(-0.5f, 0), Vector2.left, 0.5f, layerMask);

                if (hit.collider == null)
                {
                    transform.position += new Vector3(-0.89f, 0, 0);
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position + new Vector3(0.5f,0 ), Vector2.right, 0.5f, layerMask);

                if (hit.collider == null)
                {
                    transform.position += new Vector3(0.89f, 0, 0);
                }
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position + new Vector3(0,0.5f), Vector2.up, 0.5f, layerMask);

                if (hit.collider == null)
                {
                    transform.position += new Vector3(0f, 0.89f, 0);
                }
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position + new Vector3(0,-0.5f), Vector2.down, 0.5f, layerMask);

                if (hit.collider == null)
                {

                    transform.position += new Vector3(0, -0.89f, 0);
                }
            }

        }
    }
}


