using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{   
   
    [SerializeField] private float speed = 10;
    bool IsCollision;
    Rigidbody rb;
    float force = 3f;
    
    
    private void OnCollisionEnter(Collision collision)
    {
        IsCollision = true;
        //force = 5f;
    }
    private void Start()
    {
        
        rb =GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        

        if (IsCollision )
        {
            
            if (transform.position.z>=-15f)
            {
                speed = 0;
                rb.AddForce(new Vector3(0, 0, -force), ForceMode.Impulse);
            }
            else
            {
                IsCollision=false;

                Invoke("TimeDelay", 3);
            }
        }
        else
        {
            rb.velocity = Vector3.forward * speed;
        }
    }
    void TimeDelay()
    {
        speed = 10f;
    }
      
   
    

}
