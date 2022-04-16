using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propeler : MonoBehaviour
{
    public GameObject plane;

    private float propellorSpeed = 10000;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);

    }
}
