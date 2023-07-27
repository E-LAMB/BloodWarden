using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanningItem : MonoBehaviour
{

    public bool plan_ready;

    public int floor_to_visit;
    public bool floor_valid;

    public void SelectFloor(int id)
    {
        floor_to_visit = id;
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

        }

        if (floor_valid)
        {
            plan_ready = true;

        } else
        {
            plan_ready = false;
        }
    }
}
