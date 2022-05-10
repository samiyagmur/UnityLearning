using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    playerInput playerInput;

    private void Start()
    {
        playerInput = new playerInput();
    }

    private void Update()
    {
        playerInput.SetInput();

    }
}
