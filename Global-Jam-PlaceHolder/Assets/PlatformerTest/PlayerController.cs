using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb2d;
    Animator anime;
    float speed = 6;
    float height = 10;
    float ad, ws;
    float jHeight = 4f;
    bool jump, grounded, ctrlFlag;
    public bool hasAI = true;
    Vector3 overlap;
    public LayerMask ground;


    //holds movement that goes into rb2d
    float move;


    void Start()
    {
        ctrlFlag = true;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
            ctrlFlag = !ctrlFlag;
        if (ctrlFlag)
        {
            overlap = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.35f, gameObject.transform.position.y);
            ad = Input.GetAxis("Horizontal");
            ws = Input.GetAxis("Vertical");
            jump = Input.GetButton("Jump");

            grounded = Physics2D.OverlapCircle(overlap, 0.5f, ground);
            //if the jumpButton is pressed and the player is grounded then the velocity of y for rb2d changes to 1 * speed causing the player to jump
           // print(grounded);
        }
        

    }

    private void FixedUpdate()
    {

        if (ctrlFlag)
        {
            if (Input.GetKey(KeyCode.D))
            {

                transform.eulerAngles = new Vector2(0, 0);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.eulerAngles = new Vector2(0, 0);
            }
            int layerMask = LayerMask.GetMask("Platform");
            RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position - new Vector3(0, 1.0f), Vector2.down, 0.25f, layerMask);
            Debug.DrawRay(gameObject.transform.position - new Vector3(0, 1.0f), Vector2.down, Color.green);

            move = ad * speed;
            if (jump && hit)
            {
                print("jump");
                rb2d.velocity = new Vector2(rb2d.velocity.x, 1 * height);
            }
            rb2d.velocity = new Vector2(move, rb2d.velocity.y);
            if (rb2d.velocity.y < 0)
            {
                rb2d.velocity += Vector2.up * Physics2D.gravity.y * (jHeight - 1) * Time.deltaTime;
            }
            else if (rb2d.velocity.y > 0 && !Input.GetButton("Jump"))
            {
                rb2d.velocity += Vector2.up * Physics2D.gravity.y * (jHeight - 1) * Time.deltaTime;
            }
        }

    }
    void OnDrawGizmosSelected()
    {
        Color c = new Vector4(0, 1f, 0, 0.25f);
        // Draw a yellow sphere at the transform's position
        Gizmos.color = c;
        Gizmos.DrawSphere(overlap, 0.5f);

    }


}
