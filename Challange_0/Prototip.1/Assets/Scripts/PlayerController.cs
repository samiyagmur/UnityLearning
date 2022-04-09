using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 5.0f;
    private float turnSpeed=50.0f;
    private float horizantalInput;
    private float verticalInput;
    private float rotation;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is Where we get player input
        verticalInput = Input.GetAxis("Vertical");
        horizantalInput = Input.GetAxis("Horizontal");
        //We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed* verticalInput);
        //We turn rigt andleft
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizantalInput);
    }
}
