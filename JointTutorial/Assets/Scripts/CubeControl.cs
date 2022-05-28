using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{   
   
    [SerializeField] private float speed = 10;
    bool IsCollision;
    Rigidbody rb;
    float force=5f;
    float time;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("girdi");
        IsCollision = true;

        float _delayTime
        //speed = 0;
        //Vector3.Lerp(new Vector3(0, 0, -3.17993f), new Vector3(0, 0, -15f), 10);
        //speed = 10;
        //rb.MovePosition(new Vector3(0, 0, -15f)) ;
        //rb.AddForce(new Vector3(0, 0, -3.17993f), ForceMode.Impulse);
        
        //rb.velocity = Vector3.back * 10;


    }
   
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (transform.position.z==-15)
        {

        }

    }
    private void Update()
    {
        Debug.Log(IsCollision);



        if (IsCollision)
        {

            if (transform.position.z >= -15f)
            {
                speed = 0;
                rb.AddForce(new Vector3(0, 0, -force), ForceMode.Impulse);
            }
            //IsCollision = false;
            //force = 0;
        }
        



            //transform.Translate(Vector3.up * Time.deltaTime * speed* Input.GetAxis("Vertical"));
            //transform.Translate(Vector3.forward * Time.deltaTime * speed /** Input.GetAxis("Horizontal")*/);
            rb.velocity = Vector3.forward*speed;
            
    }

    void TimeDelay()
    {
        
    }
    

}
