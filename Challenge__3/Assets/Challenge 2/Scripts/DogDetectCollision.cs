using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogDetectCollision : MonoBehaviour
{
    private PlayerControllerX playerController;
    
    
        
    
    private void OnTriggerEnter (Collider other)
    {         
        playerController = FindObjectOfType<PlayerControllerX>();
        playerController.DecreaseHealt();
        
        Destroy(gameObject);
        
    }


}
