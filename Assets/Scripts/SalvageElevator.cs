using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SalvageElevator : MonoBehaviour
{

    public LayerMask player_layer;

    public GameObject myself;

    public PlayerMovement the_player;

    public int to_load;

    public string floor_name;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void AddTheItem(string the_item)
    {
        if (the_item == "water") { Mind.storage_water += 1; }
        if (the_item == "food") { Mind.storage_food += 1; }
        if (the_item == "fuses") { Mind.storage_fuses += 1; }
        if (the_item == "gears") { Mind.storage_gears += 1; }
        if (the_item == "tools") { Mind.storage_tools += 1; }

        if (the_item == "specimen") { Mind.storage_specimen += 1; }
    }

    // Start is called before the first frame update
    void LeaveLevel()
    {

        if (Mind.has_item_1) { AddTheItem(Mind.item_1); }
        if (Mind.has_item_2) { AddTheItem(Mind.item_2); }
        if (Mind.has_item_3) { AddTheItem(Mind.item_3); }
        if (Mind.has_item_4) { AddTheItem(Mind.item_4); }
        if (Mind.has_item_5) { AddTheItem(Mind.item_5); }

        AddTheItem(Mind.item_6);

        Mind.item_1 = "na";
        Mind.item_2 = "na";
        Mind.item_3 = "na";
        Mind.item_4 = "na";
        Mind.item_5 = "na";
        Mind.item_6 = "na";

        Mind.has_item_1 = false;
        Mind.has_item_2 = false;
        Mind.has_item_3 = false;
        Mind.has_item_4 = false;
        Mind.has_item_5 = false;
        Mind.has_item_6 = false;

        Mind.collected_items = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.CheckSphere(myself.transform.position, Mind.interaction_range_items, player_layer))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                LeaveLevel();
                UnityEngine.SceneManagement.SceneManager.LoadScene(to_load);
            }
        }
    }
}
