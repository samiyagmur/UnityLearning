using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball_Transform : MonoBehaviour
{
    // Start is called before the first frame update
    //public Vector3 scaleChange;
    //public Vector3 positionChange;
    public Vector3 rotateChange;
    void Start()
    {


        

    }

    // Update is called once per frame
    void Update()
    {
        
        
        //transform.localScale += scaleChange;
        //transform.position += positionChange;
        transform.Rotate(rotateChange);
    }

}
