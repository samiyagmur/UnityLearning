using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBound : MonoBehaviour
{
    // Start is called before the first frame update
    private float BoundDestroyPoint = 34f;
    private float lowerBound = -10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > BoundDestroyPoint)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over");
            Destroy(gameObject);
            
        }
    }
}
