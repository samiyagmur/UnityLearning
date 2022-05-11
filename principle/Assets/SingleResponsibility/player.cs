using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    playerInput _playeInput;
    playerMovement _playerMovement;

    private void Start()
    {
        _playeInput = new playerInput();
        _playerMovement = new playerMovement(GetComponent<Rigidbody>(),5);
    }

    private void Update()
    {
        _playeInput.SetInput();

    }
}
