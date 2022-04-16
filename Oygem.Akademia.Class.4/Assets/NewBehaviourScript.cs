using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        MyAddForce(new Vector3(0, 1000, 0));

    }

    
    void Update()
    {
        
    }

    void MyAddForce(Vector3 force)
    {
        rb.velocity += force / rb.mass;
    }

}
//diziler//
//Collider[] myColliders = gameObject.GetComponents<Collider>();//Kaç adet collader varsa onu içine yazar
//myColliders[0].enabled = false;//dizinin 0 daki collider kapatýr.
//MeshRenderer[] myRenderers = gameObject.GetComponentsInChildren<MeshRenderer>();

//for (int i = 0; i < myRenderers.Length; i++)
//{
//    myRenderers[i].material.color = Color.red;
//}

//GameObject[] myCubes = GameObject.FindGameObjectsWithTag("Cube");

//foreach (var m in myCubes)
//{
//    m.GetComponent<MeshRenderer>().material.color = Color.blue;
//}