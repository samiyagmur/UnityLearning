using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMeneger : MonoBehaviour
{
    #region private veriables


    PlayerInput playerInput;

    #endregion


    private void Awake()
    {

        playerInput = GetComponent<PlayerInput>();

        PlayerInputActions actions = new PlayerInputActions();
        actions.PlayerControl.Jump.performed += Jump;
        actions.PlayerControl.Movement.performed += Move;

        //actions.Enable();//Bu �ekilde t�m player controlu a�ar�z
        actions.PlayerControl.Enable();
    }

    private void Update()
    {

        SwitchWorkPlace();
    }


    public void SwitchWorkPlace()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {

            playerInput.SwitchCurrentActionMap("UI");//ToDo:�t'Ll be change control inteface.
        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {

            playerInput.SwitchCurrentActionMap("Player Control");
        }
    }
    public void Submit(InputAction.CallbackContext context)
    {
        Debug.Log("Submit" + context.phase);
    }


    public void OnPressJumpKey(InputAction.CallbackContext context)
    {
        
        if (context.performed)
        {
            
        }
    }
    public void Move(InputAction.CallbackContext context)
    {
        
    }
}
