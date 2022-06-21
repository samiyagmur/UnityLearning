using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{   
   
    [SerializeField] private float speed = 10;
    private float backspeed = 30f;
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

                rb.velocity = Vector3.back * backspeed;

                backspeed -=0.75f;

                Debug.Log(backspeed);

                //rb.AddForce(new Vector3(0, 0, -force), ForceMode.Impulse);
            }
            else
            {
                backspeed = 30f;
                IsCollision =false;

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
