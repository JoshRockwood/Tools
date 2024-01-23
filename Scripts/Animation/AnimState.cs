using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimState : MonoBehaviour
{
    private bool isRunning = false;
    private bool isJumping = false;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = !isRunning;
            animator.SetBool("isRunning", isRunning);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            isJumping = !isJumping;
            animator.SetBool("isJumping", isJumping);
        }
    }
}
