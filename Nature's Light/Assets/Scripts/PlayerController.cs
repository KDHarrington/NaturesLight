﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Animator animator;
    public float playerSpeed; //speed player moves

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        MoveForward(); // Player Movement 
    }

    void MoveForward()
    {
        animator.SetBool("IsRunningLeft", false);
        animator.SetBool("IsRunningRight", false);
        animator.SetBool("IsRunningUp", false);
        animator.SetBool("IsRunningDown", false);

        if (Input.GetKey("up"))
        {
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
            animator.SetBool("IsRunningUp", true);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            animator.SetBool("IsRunningDown", true);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
            animator.SetBool("IsRunningLeft", true);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
            animator.SetBool("IsRunningRight", true);
        }
    }
}
