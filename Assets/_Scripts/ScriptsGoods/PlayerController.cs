using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private float speedLinear = 5;
    private float zero = 0f;
    //private float angle;
    private float inputHorizontal, inputVertical;
    private Rigidbody rb;
    private CheckCollisions _checkCollisions;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        _checkCollisions = GameObject.Find("Player").GetComponent<CheckCollisions>();
    }
    

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer() // Movimiento player.
    {
        
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");

        if (inputHorizontal > zero || inputHorizontal < zero || inputVertical > zero || inputVertical < zero)
        {
            if (_checkCollisions.IsInvert)
            {
                Debug.Log("Estoy aqui");
                
                if (Input.GetKey(KeyCode.D))
                {
                    rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speedLinear * 0.5f);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speedLinear * -0.5f);
                }
                if (Input.GetKey(KeyCode.W))
                {
                    rb.velocity = new Vector3(speedLinear *  -0.5f, rb.velocity.y, rb.velocity.z);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    rb.velocity = new Vector3(speedLinear * 0.5f, rb.velocity.y, rb.velocity.z);
                }
            }
            else
            {
                rb.velocity = new Vector3(speedLinear * inputHorizontal, rb.velocity.y, speedLinear * inputVertical);
            }
            //angle = Mathf.Atan2(inputHorizontal, inputVertical)  * Mathf.Rad2Deg;
            //transform.rotation = Quaternion.Euler(zero, 90 + angle, zero);
            
        }
        else
        {
            rb.velocity = new Vector3(zero, rb.velocity.y, zero);
        }
    }
}
