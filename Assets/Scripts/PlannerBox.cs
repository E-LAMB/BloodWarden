using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlannerBox : MonoBehaviour
{

    public LayerMask player_layer;

    public GameObject canvas;
    public GameObject myself;
    public bool menu_state;

    public PlayerMovement the_player;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        menu_state = false;
    }

    public void Disappear()
    {
        canvas.SetActive(false);
        menu_state = false;
        the_player.in_control = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.CheckSphere(myself.transform.position, Mind.interaction_range_items, player_layer))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                menu_state = !menu_state;
                canvas.SetActive(menu_state);
                the_player.in_control = !menu_state;
            }
        }
    }
}

