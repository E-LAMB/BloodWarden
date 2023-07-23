using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowStorage : MonoBehaviour
{

    public TextMesh my_text;
    public string to_show;

    // Update is called once per frame
    void Update()
    {

        my_text.text = to_show + ": ";

        if (to_show == "food") { my_text.text += Mind.storage_food.ToString(); }
        if (to_show == "water") { my_text.text += Mind.storage_water.ToString(); }
        if (to_show == "fuses") { my_text.text += Mind.storage_fuses.ToString(); }
        if (to_show == "tools") { my_text.text += Mind.storage_tools.ToString(); }
        if (to_show == "gears") { my_text.text += Mind.storage_gears.ToString(); }

        if (to_show == "specimen") { my_text.text += Mind.storage_specimen.ToString(); }
        if (to_show == "meds") { my_text.text += Mind.storage_meds.ToString(); }
    }
}
