﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Joystick _androidJoystick;
    public Animator _animator;
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

      private int Androidmovement = 0;

    void Update()
    {
        horizontalMove = (Input.GetAxisRaw("Horizontal") + _androidJoystick.Horizontal + Androidmovement) * runSpeed;
       // Debug.Log(Input.GetAxisRaw("Horizontal"));

        if (_androidJoystick.Horizontal != 0)
            Debug.Log(_androidJoystick.Horizontal);
        _animator.SetFloat("walk", Mathf.Abs(horizontalMove));


        if (Input.GetButtonDown("Jump"))
        {
           Jump();
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void Left()
    {
        if (isActiveAndEnabled) {
        Androidmovement = -1;
        }
    }
    public void Right()
    {
        if (isActiveAndEnabled) {
        Androidmovement = 1;
        }
    }
    public void ResetLeftAndRight()
    {
        if (isActiveAndEnabled) {
        Androidmovement = 0;
        }
    }

    public void Jump() 
    {
        if (isActiveAndEnabled) {
        jump = true;
        _animator.SetBool("Jump", true);
        }
    }

    public void Onlanding()
    {
        _animator.SetBool("Jump", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
