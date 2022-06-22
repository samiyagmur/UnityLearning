using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControl : MonoBehaviour
{   
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Movement()
    {
       

        
       //rb.velocity=new Vector3(newValue.x, newValue.y, newValue.z);
    }



    public void Jump()
    {
        
       rb.AddForce(Vector3.up*5,ForceMode.Impulse);
    }
}
    