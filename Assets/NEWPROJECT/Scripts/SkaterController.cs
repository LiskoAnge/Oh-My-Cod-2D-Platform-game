using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkaterController : MonoBehaviour
{
    public Rigidbody2D rgbd;
    public bool moveRight;
    public bool moveLeft;
    private float movement;
    public float skaterSpeed;
    public float jumpForce;
    private Animator anim;
    public bool isLanded = false;
    private bool isJumping;

    private void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        moveLeft = false;
        moveRight = false;
    }

    public void OnPointerDownLeft()
    {
        moveLeft = true;
    }
    public void OnPointerDownRight()
    {
        moveRight = true;
    }
    public void PointerUpLeft()
    {
        moveLeft = false;
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }

    private void Update()
    {
        MovementPlayer();

        if (isLanded == false)
        {
            anim.SetBool("isJumping", true);
        } else
        {
            anim.SetBool("isJumping", false);
        }
    }

    private void MovementPlayer()
    {
        if (moveLeft)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("isWalking", true);
            movement = -skaterSpeed;
        } else if (moveRight)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("isWalking", true);
            movement = skaterSpeed;
        } else
        {
            anim.SetBool("isWalking", false);
            movement = 0;
        }
    }

    private void FixedUpdate()
    {
        rgbd.velocity = new Vector2(movement, rgbd.velocity.y);
    }

    public void PressJump()
    {
        if (isLanded == true)
        {
            isJumping = true;
            rgbd.velocity = Vector2.up * jumpForce;
        }
    }   
}



