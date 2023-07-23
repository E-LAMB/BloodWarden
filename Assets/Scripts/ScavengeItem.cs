using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScavengeItem : MonoBehaviour
{

    public string my_code;
    public string my_type;

    public LayerMask player_layer;

    public GameObject myself;

    public bool is_special;

    // Start is called before the first frame update
    void Start()
    {
        if (Mind.player_inventory.Contains(my_code))
        {
            myself.SetActive(false);
        }
        Debug.Log(Mind.item_1 + "/" + Mind.item_2 + "/" + Mind.item_3 + "/" + Mind.item_4 + "/" + Mind.item_5);
    }

    void Pickup()
    {

        if (my_type == "food") { Mind.storage_food += 1; }
        if (my_type == "water") { Mind.storage_water += 1; }
        if (my_type == "gears") { Mind.storage_gears += 1; }
        if (my_type == "tools") { Mind.storage_tools += 1; }
        if (my_type == "fuses") { Mind.storage_fuses += 1; }

        if (my_type == "specimen") { Mind.storage_specimen += 1; }

        Debug.Log(Mind.item_1 + "/" + Mind.item_2 + "/" + Mind.item_3 + "/" + Mind.item_4 + "/" + Mind.item_5);

        Mind.collected_items += 1;

        Mind.player_inventory += my_code + "/";
        myself.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.CheckSphere(myself.transform.position, Mind.interaction_range_items, player_layer))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Pick");

                if (!is_special)
                {
                    if (my_type == Mind.item_1 && !Mind.has_item_1) { Mind.item_1 = "GOT";  Mind.has_item_1 = true; Pickup(); }
                    else if (my_type == Mind.item_2 && !Mind.has_item_2) { Mind.item_2 = "GOT"; Mind.has_item_2 = true; Pickup(); }
                    else if (my_type == Mind.item_3 && !Mind.has_item_3) { Mind.item_3 = "GOT"; Mind.has_item_3 = true; Pickup(); }
                    else if (my_type == Mind.item_4 && !Mind.has_item_4) { Mind.item_4 = "GOT"; Mind.has_item_4 = true; Pickup(); }
                    else if (my_type == Mind.item_5 && !Mind.has_item_5) { Mind.item_5 = "GOT"; Mind.has_item_5 = true; Pickup(); }
                }
                
                if (is_special)
                {
                    if (!Mind.has_item_6) { Mind.item_6 = my_type; Mind.has_item_6 = true; Pickup(); }
                }
                
            }
        }
    }
}
