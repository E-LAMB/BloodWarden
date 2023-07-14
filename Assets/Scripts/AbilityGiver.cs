using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityGiver : MonoBehaviour
{

    public PlayerAbility3 ability_script;
    public bool gives_save_ability;

    public Transform self;

    public float interaction_range;
    public LayerMask player_layer;
    public bool player_is_close;

    public bool interacted_with;
    public GameObject other_bridge;

    // Update is called once per frame
    void Update()
    {
        player_is_close = Physics.CheckSphere(self.position, interaction_range, player_layer);
        if (player_is_close && Input.GetKeyDown(KeyCode.E) && !interacted_with)
        {
            if (gives_save_ability) {ability_script.has_save = true;}
            if (!gives_save_ability) {ability_script.has_load = true;}
            interacted_with = true;
            other_bridge.SetActive(true);
            gameObject.SetActive(false);
        }   

    }
}
