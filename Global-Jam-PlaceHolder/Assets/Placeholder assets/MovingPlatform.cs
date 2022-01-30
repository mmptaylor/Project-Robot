using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public GameObject pos1;
    public GameObject pos2;
    public float speed;
    public bool moving;
    bool pos;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        pos1 = GameObject.Find("Pos1");
        pos2 = GameObject.Find("Pos2");
        rb2d = GetComponent<Rigidbody2D>();
        pos = true;
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            if (!pos)
            {
                // rb2d.velocity = new Vector2(speed, 0);
                transform.position += new Vector3(speed * 0.01f,0f, 0);
                rb2d.velocity = new Vector3(5, 0, 0);
                if (transform.position.x > pos2.transform.position.x)
                {
                    pos = !pos;
                    print("switch");
                }
            }
            else if (pos)
            {
                //  rb2d.velocity = new Vector2(speed, 0);
                transform.position -= new Vector3(speed * 0.01f, 0f, 0);
                rb2d.velocity = new Vector3(-5, 0, 0);
                if (transform.position.x < pos1.transform.position.x)
                {
                    pos = !pos;
                }
            }
        }
    }
}
