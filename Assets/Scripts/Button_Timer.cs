using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Timer : MonoBehaviour
{

    public bool active_state = false;

    public GameObject playerChecker;
    public LayerMask playerLayer;

    public GameObject my_prompt; 

    public Status own_status;

    public float distance_required = 1.0f;

    bool is_close;

    public float max_time;
    public float my_time;

    public GameObject glow_button;
    public GameObject grey_button;
    public bool should_glow;

    void Update()
    {

        should_glow = active_state;
        if (!should_glow) {glow_button.SetActive(true);}
        if (!should_glow) {grey_button.SetActive(false);}
        if (should_glow) {glow_button.SetActive(false);}
        if (should_glow) {grey_button.SetActive(true);}

        if (my_time > 0f)
        {
            my_time -= Time.deltaTime;
            active_state = true;
        } else
        {
            active_state = false;
        }

        is_close = Physics.CheckSphere(playerChecker.transform.position, distance_required, playerLayer);

        if (Input.GetKeyDown(KeyCode.E) && is_close == true)
        {
            my_time = max_time;
        }

        if (is_close == true && active_state == false)
        {
            my_prompt.SetActive(true);
        }

        if (is_close == false && active_state == false)
        {
            my_prompt.SetActive(false);
        }

        if (active_state == true)
        {
            my_prompt.SetActive(false);
        }

        own_status.is_active = active_state;

    }
}
