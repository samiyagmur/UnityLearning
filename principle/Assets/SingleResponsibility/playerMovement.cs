using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement
{
    Rigidbody rb;
    float movementSpeed;
   public playerMovement(Rigidbody _rb,float _movementSpeed)
    {
        rb = _rb;
        movementSpeed = _movementSpeed;
    }

    public void Movement(float horizontal)
    {
        Vector3 vec = new Vector3(horizontal*movementSpeed,0,0);
        rb.velocity = vec;
    }
}
