using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogDetectCollision : MonoBehaviour
{

    private void OnTriggerEnter (Collider other)
    {       
            Destroy(gameObject);
            Debug.Log("Game Over");

            UnityEditor.EditorApplication.isPlaying = false;
    }

    
}
