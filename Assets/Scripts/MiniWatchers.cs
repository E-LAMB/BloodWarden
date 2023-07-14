using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MiniWatchers : MonoBehaviour
{

    public NavMeshAgent my_agent;
    public Animator my_anim;

    public bool is_active;
    public Status my_activator;

    public float speed;
    public GameObject player;

    public bool is_moving;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && is_active)
        {
            Debug.Log("Death2");
            Debug.Break();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        is_active = my_activator.is_active;

        if (is_active)
        {
            my_agent.speed = speed;
            my_agent.SetDestination(player.transform.position);
        } else
        {
            my_agent.speed = 0f;
        }

        Vector3 extraction = my_agent.velocity;
        float norm = extraction.magnitude;
        if (norm > 0)
        {
            is_moving = true;
        } else
        {
            is_moving = false;
        }
        
        my_anim.SetBool("IsMoving", is_moving);

    }
}
