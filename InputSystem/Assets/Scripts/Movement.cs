using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public void movement(Rigidbody rb, Vector3 direction)
    {
        rb.velocity = new Vector3(direction.x, 0, direction.y) * 5;
    }


}
