using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D Controller;

    float HorizontalMovement = 0f;
    public float VerticalMovement = 0f;
    public float RunSpeed = 40f;
    bool jump = false;

    void Update()
    {
        HorizontalMovement = Input.GetAxisRaw("Horizontal") * RunSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        Controller.Move(HorizontalMovement * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

}
