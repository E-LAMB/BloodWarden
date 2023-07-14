using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Standing : MonoBehaviour
{

    public bool active_state = false;

    public GameObject playerChecker;
    public LayerMask playerLayer;
    public LayerMask cloneLayer;

    public Status own_status;

    bool is_close_player;
    bool is_close_clone;

    void Update()
    {

        is_close_player = Physics.CheckSphere(playerChecker.transform.position, 0.3f, playerLayer);
        is_close_clone = Physics.CheckSphere(playerChecker.transform.position, 0.3f, cloneLayer);

        if (is_close_player || is_close_clone)
        {
            active_state = true;
        }
        else 
        {
            active_state = false;
        }

        own_status.is_active = active_state;

    }
}
