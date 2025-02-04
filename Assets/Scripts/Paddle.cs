using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Down
        if (Input.GetKey(KeyCode.S))
        {
            Transform paddleTransform = GetComponent<Transform>();
            paddleTransform.position += new Vector3(0f, 0f, -1f * Time.deltaTime);
        }

        //Up
        if (Input.GetKey(KeyCode.W))
        {
            Transform paddleTransform = GetComponent<Transform>();
            paddleTransform.position += new Vector3(0f, 0f, +1f * Time.deltaTime);
        }
    }
}
