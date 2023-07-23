using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanningItem : MonoBehaviour
{

    public bool plan_ready;

    public int chosen_1 = -1;
    public int chosen_2 = -1;
    public int chosen_3 = -1;
    public int chosen_4 = -1;
    public int chosen_5 = -1;

    public int max_cap;

    public string[] all_texts;

    public Text text_1;
    public Text text_2;
    public Text text_3;
    public Text text_4;
    public Text text_5;

    public int floor_to_visit;
    public bool floor_valid;

    public void SelectFloor(int id)
    {
        floor_to_visit = id;
    }

    public void NextItem(int id)
    {
        if (id == 1)
        {
            chosen_1 += 1;
            if (chosen_1 > max_cap) { chosen_1 = 0; }
        }

        if (id == 2)
        {
            chosen_2 += 1;
            if (chosen_2 > max_cap) { chosen_2 = 0; }
        }

        if (id == 3)
        {
            chosen_3 += 1;
            if (chosen_3 > max_cap) { chosen_3 = 0; }
        }

        if (id == 4)
        {
            chosen_4 += 1;
            if (chosen_4 > max_cap) { chosen_4 = 0; }
        }

        if (id == 5)
        {
            chosen_5 += 1;
            if (chosen_5 > max_cap) { chosen_5 = 0; }
        }

    }

    public void PriorItem(int id)
    {
        if (id == 1)
        {
            chosen_1 += -1;
            if (chosen_1 < 0) { chosen_1 = max_cap; }
        }

        if (id == 2)
        {
            chosen_2 += -1;
            if (chosen_2 < 0) { chosen_2 = max_cap; }
        }

        if (id == 3)
        {
            chosen_3 += -1;
            if (chosen_3 < 0) { chosen_3 = max_cap; }
        }

        if (id == 4)
        {
            chosen_4 += -1;
            if (chosen_4 < 0) { chosen_4 = max_cap; }
        }

        if (id == 5)
        {
            chosen_5 += -1;
            if (chosen_5 < 0) { chosen_5 = max_cap; }
        }

    }

    private void Start()
    {
        floor_to_visit = 0;
    }

    private void Update()
    {

        if (floor_to_visit == 0)
        {
            floor_valid = false;
        } else
        {

            if (floor_to_visit == 1) // FLOOR A
            {
                if (Mind.floor_A_food > 0)
            }



        }

        if (chosen_1 != -1 && chosen_2 != -1 && chosen_3 != -1 && chosen_4 != -1 && chosen_5 != -1 && floor_valid)
        {
            plan_ready = true;

        } else
        {
            plan_ready = false;
        }

        text_1.text = all_texts[chosen_1 + 1];
        text_2.text = all_texts[chosen_2 + 1];
        text_3.text = all_texts[chosen_3 + 1];
        text_4.text = all_texts[chosen_4 + 1];
        text_5.text = all_texts[chosen_5 + 1];
    }
}
