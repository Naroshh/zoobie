using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBrain : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float attackDistance;

    private Rigidbody rb;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

       
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.LookAt(Player.GetPlayer().transform.position);
        
        // Too far: walk closer
        if (Vector3.Distance(transform.position, Player.GetPlayer().transform.position) > attackDistance)
        {
            animator.Play("Z_Run_InPlace");
            rb.AddForce(transform.forward * moveSpeed, ForceMode.Acceleration);
        }
        // Close enough to attack
        else
        {
            animator.Play("Z_Attack");
        }
    }
}
