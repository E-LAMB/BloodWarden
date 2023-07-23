using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public bool in_control;

    public float walking_speed; 
    public float sprinting_speed;
    float speed;
    public bool currently_sprinting;
    public bool currently_hiding;

    public int the_id;

    public Rigidbody my_rigidbody;

    public Transform my_body;

    public Animator anim;
    public bool is_moving;

    // Start is called before the first frame update
    void Start()
    {
        speed = walking_speed;
    }

    // Update is called once per frame
    void Update()
    {

        currently_sprinting = Input.GetKey(KeyCode.LeftShift);

        if (currently_sprinting) { speed = sprinting_speed; } else { speed = walking_speed; }

        /*if (Input.GetKeyUp(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(the_id);
        }*/

        if (in_control)
        {
            my_rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, Input.GetAxis("Vertical") * speed);
            my_body.LookAt(my_body.position + my_rigidbody.velocity);
            my_body.eulerAngles = new Vector3(0f, my_body.eulerAngles.y, 0f);

        } else
        {
            my_rigidbody.velocity = new Vector3(0f, 0f, 0f);
        }

        if (in_control && (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0))
        {
            is_moving = true;

        } else
        {
            is_moving = false;
        }

        anim.SetBool("anim_is_moving", is_moving);

        if (is_moving && in_control)
        {
            if (currently_sprinting)
            {
                anim.speed = 1.2f;
            } else
            {
                anim.speed = 0.6f;
            }
        } else
        {
            anim.speed = 0.75f;
        }
    }
}
