
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30f;
    private float bottomLimit = -5f;
    private float zLimit = 10f;
    private PlayerControllerX playerController;

    private void Awake()
    {
        playerController = FindObjectOfType<PlayerControllerX>();
    }

    void Update()
    {
        
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
            
        }
        
        else if (transform.position.y < bottomLimit)
        {
            playerController.DecreaseHealt();
            Destroy(gameObject);
           

        }
        else if (transform.position.z > zLimit) 
        {
            Destroy(gameObject);
        }
        //isBoubleDestroy=false;  
    }
}
