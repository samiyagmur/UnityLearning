using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput
{
    //SingleResponsibility prensibi bir clasýn sadece bir iþi yapmasý üzerine olan prensiptir.

    public float horizantal { get; private set; }

    public void SetInput()
    {
        horizantal = Input.GetAxis("Horizontal");
    }
}
