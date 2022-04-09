using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlRed : MonoBehaviour
{
    private float speed=-25f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

        verticalInput = Input.GetAxis("VerticalRed");
        horizontalInput = Input.GetAxis("HorizontalRed");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}
