using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30f;
    private float bottomLimit = -5f;
    private float zLimit = 10f;
    //PlayerControllerX playerController;
    
    // Update is called once per frame
    
        
   
    void Update()
    {
        int healts= gameObject.GetComponent<PlayerControllerX>().Healt;
        
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        
        else if (transform.position.y < bottomLimit)
        {
            
            Destroy(gameObject);
            healts--;
            gameObject.GetComponent<PlayerControllerX>().Healt = healts;


        }
        else if (transform.position.z > zLimit) 
        {
            Destroy(gameObject);
            
        }

    }
}
