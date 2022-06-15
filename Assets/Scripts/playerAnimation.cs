using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{
    Animator animator;
    public float moveSpeed = 0;
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
        interact();
        defending();
    }
    void regularAnimation()
    {
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            moveSpeed += 1;
            if (moveSpeed > 100)
            {
                animator.SetBool("isRunning", true);
            }
            else
            {
                animator.SetBool("isWalking", true);
            }
        }
        else
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isWalking", false);
            moveSpeed = 0;
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
    void interact()
    {
        animator.ResetTrigger("interacting");
        if (Input.GetKeyDown("e"))
        {
            animator.SetTrigger("interacting");
        }
        /*once objects are added use
         * if (touching item)
         *{
         *animator.SetTrigger("pickingUp")
         *}
         */
    }
    void defending()
    {
        if (Input.GetMouseButton(1))
        {
            animator.SetBool("isDefending", true);
        }
        animator.SetBool("isDefending", false);
    }
}
