using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public  CharacterController2D controller;
    
    public float horizontalMove = 40f;

    float runSpeed = 30f;

    bool jump = false;


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            runSpeed = runSpeed * 2;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * UnityEngine.Time.fixedDeltaTime, false, jump);
        jump = false;
        runSpeed = runSpeed = 30f;
    }
}
