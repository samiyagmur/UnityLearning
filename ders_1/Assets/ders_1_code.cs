using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ders_1_code : MonoBehaviour
{

    public float objectSpeed = 10f;

    private void Start()
    {
        //gimball lock
        //quertion
        //kendi etraf�nda 3 eksenli d�n�� y�ntemi
        transform.Rotate(xAngle:15f, yAngle:35f, zAngle:25f,relativeTo:Space.World);
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        //Debug.Log(message: "Horizantal: " + horizontalInput);
        //Debug.Log(message: "Vertical: " + verticalInput);
        //Nesneyi bir y�ne hareket etmek i�in 3 eksendede tan�mlama yapmak gerekir.
        //Time.deltTime methodu Tu�a bast���m�z s�re boyunca cismi hareket ettir anlam�na gelir
        //transform.position += new Vector3(x: horizontalInput * Time.deltaTime, y:0f,z:verticalInput * Time.deltaTime);
        //Cismi bas�l� s�rede daha h�zl� g�t�rmek i�in belirledi�imiz bir say� ile �arpabiliriz.
        //transform.position += new Vector3(x: horizontalInput * Time.deltaTime*objectSpeed, y: 0f, z: verticalInput * Time.deltaTime*objectSpeed);



    }
}
