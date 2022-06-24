using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControl : MonoBehaviour
{
    Rigidbody rb;
    InputMeneger inputManger;

    private void Awake()
    {
       rb= GetComponent<Rigidbody>(); 
       inputManger= GetComponent<InputMeneger>();
    }
    private void Update()
    {
        MovementControl();
    }
    public void MovementControl()
    {   
        Vector2 direction = context.ReadValue<Vector2>();

    }


}
