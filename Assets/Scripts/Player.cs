using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    public float moveSpeed = 5;
    //use animator.SetBool("", true)
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        regularAnimation();
        sneakyAnimation();
        jumping();
    }
    void regularAnimation()
    {
        //movement animation
        if (Input.GetKey("w"))
        {
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey("a"))
        {
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey("s"))
        {
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey("d"))
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
    void sneakyAnimation()
    {
        if (Input.GetKey("left shift"))
        {
            //forward
            animator.SetBool("isSneaky", true);
            if (Input.GetKey("w"))
            {
                animator.SetBool("sneakyWalkForward", true);
            }
            else
            {
                animator.SetBool("sneakyWalkForward", false);
            }
            //left
            if (Input.GetKey("a"))
            {
                animator.SetBool("sneakyWalkLeft", true);
            }
            else
            {
                animator.SetBool("sneakyWalkLeft", false);
            }
            //back
            if (Input.GetKey("s"))
            {
                animator.SetBool("sneakyWalkBack", true);
            }
            else
            {
                animator.SetBool("sneakyWalkBack", false);
            }
            //right
            if (Input.GetKey("d"))
            {
                animator.SetBool("sneakyWalkRight", true);
            }
            else
            {
                animator.SetBool("sneakyWalkRight", false);
            }
        }
        else
        {
            animator.SetBool("isSneaky", false);
        }
    }
    void jumping()
    {
        animator.ResetTrigger("jumped");
        if (Input.GetKeyDown("space"))
        {
            animator.SetTrigger("jumped");
        }
    }
}
