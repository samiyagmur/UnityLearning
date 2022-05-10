using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{

    [SerializeField] MovementStyle movementStyle;

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            movementStyle.Move(this,Vector3.forward); 
        }
    }
}
