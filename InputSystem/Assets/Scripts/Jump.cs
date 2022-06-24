using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public void Jumping(Rigidbody rb)
    {
        rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }
}
