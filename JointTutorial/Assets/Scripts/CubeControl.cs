using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{   
   
    [SerializeField] private float speed = 10;
    public PhysicMaterial material;
    Rigidbody rb;
    private void OnCollisionEnter(Collision collision)
    {
        
      
        
    }
    private void Start()
    {   
       
        material.bounciness = 1f;
        
        rb= GetComponent<Rigidbody>();
    }

    private void Update()
    {
            
            

            
            Debug.Log("girdi");
            //transform.Translate(Vector3.up * Time.deltaTime * speed* Input.GetAxis("Vertical"));
            //transform.Translate(Vector3.forward * Time.deltaTime * speed /** Input.GetAxis("Horizontal")*/);
            rb.velocity = Vector3.forward*speed;
    }

}
