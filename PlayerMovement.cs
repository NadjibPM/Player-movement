using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterControler2D controller;
    public float horizontalMove =0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")* runSpeed ;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
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
    void FixedUpdate() 
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch ,jump);
        jump = false;
    }
}
