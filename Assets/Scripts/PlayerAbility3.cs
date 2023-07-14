using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbility3 : MonoBehaviour
{

    public Transform player_trans;

    bool isOnGround;

    public GameObject groundChecker;
    public LayerMask groundLayer;

    // Update is called once per frame
    void Update()
    {
        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);
    }
}
