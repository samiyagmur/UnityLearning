using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControl : MonoBehaviour
{
    #region private veriables

    Rigidbody rb;
    PlayerInput playerInput;

    #endregion

    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        
        PlayerInputActions actions = new PlayerInputActions();
        actions.PlayerControl.Jump.performed += Jump;
        actions.PlayerControl.Movement.performed += Move;

        //actions.Enable();//Bu þekilde tüm player controlu açarýz
        actions.PlayerControl.Enable();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            playerInput.SwitchCurrentActionMap("UI");//ToDo:Ýt'Ll be change control inteface.
        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            playerInput.SwitchCurrentActionMap("Player Control");
            
            
        }
        
    }
    public void Submit(InputAction.CallbackContext context)
    {
        Debug.Log("Submit"+ context);
    }


    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("jump"+ context);
        if (context.performed)
        {
            
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }
    public void Move(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();


        rb.velocity = new Vector3(direction.x, 0, direction.y) *5;
    }
}
