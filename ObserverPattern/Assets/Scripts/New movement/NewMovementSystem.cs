using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewMovementSystem : MonoBehaviour
{
    //observer
    Rigidbody rb;
    private void Start()
    {
        //NewMovementUI.OnForwardButtonClicked += MoveForward;
        //NewMovementUI.OnBackButtonClicked += MoveBack;
        //NewMovementUI.OnRightButtonClicked += MoveRight;
        //NewMovementUI.OnLeftButtonClicked += MoveLeft;

        NewMovementUI.OnButtonClicked += Move;
        rb = GetComponent<Rigidbody>();
    }

 


    //public void MoveForward()=>rb.velocity=Vector3.forward;
    //public void MoveBack()=> rb.velocity=Vector3.back;
    //public void MoveLeft()=> rb.velocity = Vector3.left;
    //public void MoveRight()=> rb.velocity = Vector3.right;
    public void Move(Vector3 direction) =>rb.velocity = direction;
    

}
