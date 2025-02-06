using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float maxPaddleSpeed = 20f;
    public float paddleForce = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementAxis = Input.GetAxis("LeftPaddle");
        Transform paddleTransform = GetComponent<Transform>();

        Vector3 newPosition = paddleTransform.position + new Vector3(0f, 0f, movementAxis * maxPaddleSpeed * Time.deltaTime);
        newPosition.z = Math.Clamp(newPosition.z, -2.2f, -2.2f);
        
        paddleTransform.position = newPosition;
    }
}
