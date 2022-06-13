using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    //use animator.SetBool("", true)
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         animation();
    }
    void animation()
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
        //sneaky
        if (Input.GetKey("left shift"))
        {
            animator.SetBool("isSneaky", true);
            if (Input.GetKey("w"))
            {
                animator.SetBool("sneakyWalkForward", true);
            }
            else if (Input.GetKey("a"))
            {
                animator.SetBool("sneakyWalkLeft", true);
            }
            else if (Input.GetKey("s"))
            {
                animator.SetBool("sneakyWalkBack", true);
            }
            else if (Input.GetKey("d"))
            {
                animator.SetBool("sneakyWalkRight", true);
            }
            else
            {
                animator.SetBool("sneakyWalkForward", false);
                animator.SetBool("sneakyWalkLeft", false);
                animator.SetBool("sneakyWalkBack", false);
                animator.SetBool("sneakyWalkRight", false);
            }
        }
        else
        {
            animator.SetBool("isSneaky", false);
        }
    }
}
