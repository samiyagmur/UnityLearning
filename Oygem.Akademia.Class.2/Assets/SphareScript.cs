using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphareScript : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float speed=5f;
    private bool ÝsOnGround=true;
    public int score=0;
    private bool isGameFinish = false;
    
    void Start()
    {
        _rigidbody=GetComponent<Rigidbody>();
        
        
    }
     
    void Update()
    {
        
        if(Input.GetKey(KeyCode.D) && !isGameFinish)
        {
            
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A) && !isGameFinish)
        {

            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space) && ÝsOnGround && !isGameFinish)
        {   
            ÝsOnGround = false;

            _rigidbody.AddForce(Vector3.up*10f,ForceMode.Impulse);
        }
        Debug.Log(score);

    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag =="ground")
        {   
            
            ÝsOnGround = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "collectible")
        {
                score++;
               // other.gameObject.SetActive(false);
                Destroy(other.gameObject);
        }

        if (other.gameObject.tag=="Finish")
        {
            isGameFinish = true;
            Debug.Log(message:"Game is Finished");
        }
        
    }



}
