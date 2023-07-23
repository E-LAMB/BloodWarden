using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseElevator : MonoBehaviour
{

    public LayerMask player_layer;

    public GameObject myself;

    public PlayerMovement the_player;

    public float waiting_time;

    public PlanningItem planning;

    public bool loading;
    public int to_load;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.CheckSphere(myself.transform.position, Mind.interaction_range_items, player_layer))
        {
            if (Input.GetKeyDown(KeyCode.E) && planning.plan_ready && !loading)
            {
                the_player.in_control = false;
                loading = true;
                waiting_time = 0f;

                Mind.item_1 = planning.all_texts[planning.chosen_1 + 1];
                Mind.item_2 = planning.all_texts[planning.chosen_2 + 1];
                Mind.item_3 = planning.all_texts[planning.chosen_3 + 1];
                Mind.item_4 = planning.all_texts[planning.chosen_4 + 1];
                Mind.item_5 = planning.all_texts[planning.chosen_5 + 1];
            }
        }

        if (loading)
        {
            waiting_time += Time.deltaTime;
        }

        if (waiting_time > 1f)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(to_load);
        }
    }
}
