using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_Door : MonoBehaviour
{

    public Status my_button;
    public GameObject my_door;
    public bool should_invert;

    // Update is called once per frame
    void Update()
    {
        if (should_invert)
        {
            if (my_button.is_active)
            {
                my_door.SetActive(true);
            } else
            {
                my_door.SetActive(false);
            }
        } else
        {
            if (!my_button.is_active)
            {
                my_door.SetActive(true);
            } else
            {
                my_door.SetActive(false);
            }
        }
    }
}
