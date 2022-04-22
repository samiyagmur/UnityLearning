using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogDetectCollision : MonoBehaviour
{

    int healts;

    private PlayerControllerX playerControllerX;

    private void Start()
    {
        playerControllerX = FindObjectOfType<PlayerControllerX>();
    }

    private void OnTriggerEnter (Collider other)
    {
        healts = playerControllerX.Healt;

        Destroy(other.gameObject);
        healts--;

        gameObject.GetComponent<PlayerControllerX>().Healt = healts;
    }


}
