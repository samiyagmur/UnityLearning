using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 15.0f;
    private float leftSpeed = 25.0f;
    private float upSpeed = 50.0f;
    private float horizantalInput;
    private float verticalInput;
    private float upInput;
    




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        verticalInput = Input.GetAxis("Vertical");
        horizantalInput = Input.GetAxis("Horizontal");
        upInput = Input.GetAxis("Up");

        //We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * leftSpeed * horizantalInput );
        //We turn rigt andleft
        transform.Rotate(Vector3.left, Time.deltaTime * upSpeed * upInput);
        transform.Rotate(Vector3.forward, leftSpeed * Time.deltaTime * -horizantalInput);



    }
}
