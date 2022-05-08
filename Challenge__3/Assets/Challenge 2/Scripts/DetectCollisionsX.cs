using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    PlayerControllerX playerController;
    DogMovement dogMovement;
    private void OnTriggerEnter (Collider other)
    {
        dogMovement = FindObjectOfType<DogMovement>();
        dogMovement.GetDogCurrentHealtIncrease();
        //Debug.Log("sad");

        playerController = FindObjectOfType<PlayerControllerX>();
        playerController.IncreaseScore();
        Destroy(gameObject);
        
    }
}
