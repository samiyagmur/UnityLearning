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
        //kendi etrafýnda 3 eksenli dönüþ yöntemi
        transform.Rotate(xAngle:15f, yAngle:35f, zAngle:25f,relativeTo:Space.World);
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        //Debug.Log(message: "Horizantal: " + horizontalInput);
        //Debug.Log(message: "Vertical: " + verticalInput);
        //Nesneyi bir yöne hareket etmek için 3 eksendede tanýmlama yapmak gerekir.
        //Time.deltTime methodu Tuþa bastýðýmýz süre boyunca cismi hareket ettir anlamýna gelir
        //transform.position += new Vector3(x: horizontalInput * Time.deltaTime, y:0f,z:verticalInput * Time.deltaTime);
        //Cismi basýlý sürede daha hýzlý götürmek için belirlediðimiz bir sayý ile çarpabiliriz.
        //transform.position += new Vector3(x: horizontalInput * Time.deltaTime*objectSpeed, y: 0f, z: verticalInput * Time.deltaTime*objectSpeed);



    }
}
