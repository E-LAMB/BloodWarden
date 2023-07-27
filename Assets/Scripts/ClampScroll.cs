using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampScroll : MonoBehaviour
{

    public Transform to_clamp;

    public float maxi;
    public float mini;

    public bool active;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(to_clamp.position.y);
        if (active && to_clamp.position.y > maxi)
        {
            to_clamp.position = new Vector3 (to_clamp.position.x, maxi, to_clamp.position.z);
        }

        if (active && to_clamp.position.y < mini)
        {
            to_clamp.position = new Vector3 (to_clamp.position.x, mini, to_clamp.position.z);
        }
    }
}
