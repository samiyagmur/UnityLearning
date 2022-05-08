
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -35f;
    private float bottomLimit = -5f;
    private float zLimit = 10f;
    PlayerControllerX playerController;
    DogMovement dogMovement;

    private void Awake()
    {
        playerController = FindObjectOfType<PlayerControllerX>();
        dogMovement = FindObjectOfType<DogMovement>();
        
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
            dogMovement.GetDogCurrentHealtDecrease();
            Destroy(gameObject);
           

        }
        else if (transform.position.z > zLimit) 
        {
            Destroy(gameObject);
        }
        //isBoubleDestroy=false;  
    }
}
