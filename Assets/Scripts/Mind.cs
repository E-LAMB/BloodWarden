using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Mind
{

    public static bool done_reset;

    public static string player_inventory = "";

    public static float interaction_range_items = 3f;

    public static int storage_water;
    public static int storage_food;
    public static int storage_fuses = 2;
    public static int storage_gears;
    public static int storage_tools;

    public static int storage_specimen; // Special

    public static int storage_meds; // Craft Only

    // FLOOR A
    public static int floor_A_water    = 02;
    public static int floor_A_food     = 02;
    public static int floor_A_fuses    = 03;
    public static int floor_A_gears    = 03;
    public static int floor_A_tools    = 02;

    public static int floor_A_specimen = 01;
    public static bool floor_A_special = true;

    // FLOOR B
    public static int floor_B_water    = 02;
    public static int floor_B_food     = 02;
    public static int floor_B_fuses    = 03;
    public static int floor_B_gears    = 05;
    public static int floor_B_tools    = 01;

    public static int floor_B_specimen = 01;
    public static bool floor_B_special = true;

    // FLOOR C
    public static int floor_C_water    = 02;
    public static int floor_C_food     = 02;
    public static int floor_C_fuses    = 02;
    public static int floor_C_gears    = 06;
    public static int floor_C_tools    = 02;

    public static int floor_C_specimen = 02;
    public static bool floor_C_special = true;

    // FLOOR MAINT (M)
    public static int floor_M_water    = 02;
    public static int floor_M_food     = 02;
    public static int floor_M_fuses    = 04;
    public static int floor_M_gears    = 10;
    public static int floor_M_tools    = 02;

    public static int floor_M_specimen = 00;
    public static bool floor_M_special = true;

    // FLOOR BASEMENT / STORE (S)
    public static int floor_S_water    = 02;
    public static int floor_S_food     = 02;
    public static int floor_S_fuses    = 03;
    public static int floor_S_gears    = 06;
    public static int floor_S_tools    = 02;

    public static int floor_S_specimen = 01;
    public static bool floor_S_special = true;

    // Planned Supplies
    /*
    
    water
    food
    fuses
    gears
    toolbox

    specimen
    
    */
    public static string item_1 = "na";
    public static string item_2 = "na";
    public static string item_3 = "na";
    public static string item_4 = "na";
    public static string item_5 = "na";

    public static bool has_item_1 = false;
    public static bool has_item_2 = false;
    public static bool has_item_3 = false;
    public static bool has_item_4 = false;
    public static bool has_item_5 = false;

    public static bool has_item_6 = false;

    public static int collected_items;

    // Special Items
    public static string item_6 = "na";

}
