using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour
{
    public Rigidbody rb;
    public float maxPaddleSpeed = 8f;
    private Vector3 paddleDirection;
    public InputActionReference paddleAction;
    
    // Start is called before the first frame update
    // void Start()
    // {
    //     paddleDirection = paddleAction.action.ReadValue<Vector3>();
    // }
    private void Awake()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        // float movementAxis = Input.GetAxis("LeftPaddle");
        // Transform paddleTransform = GetComponent<Transform>();
        //
        // Vector3 newPosition = paddleTransform.position + new Vector3(0f, 0f, movementAxis * maxPaddleSpeed * Time.deltaTime);
        // newPosition.z = Math.Clamp(newPosition.z, -2.2f, -2.2f);
        //
        // paddleTransform.position = newPosition;

        if (paddleAction == null)
        {
            Debug.LogError("paddleAction is null!");
            return;
        }

        if (paddleAction.action == null)
        {
            Debug.LogError("paddleAction.action is null!");
            return;
        }
        
        paddleDirection = paddleAction.action.ReadValue<Vector3>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0f, 0f, paddleDirection.z * maxPaddleSpeed);
    }
}
