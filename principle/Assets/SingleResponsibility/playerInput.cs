using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput
{
    //SingleResponsibility prensibi bir clas�n sadece bir i�i yapmas� �zerine olan prensiptir.

    public float horizantal { get; private set; }

    public void SetInput()
    {
        horizantal = Input.GetAxis("Horizontal");
    }
}
