using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControl : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 10f;
    private float xRange = 21f;
    public GameObject projecTilePrefabs;



    void Start()
    {

    }


    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (xRange < transform.position.x)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(projecTilePrefabs, new Vector3(transform.position.x, 1f, transform.position.z), projecTilePrefabs.transform.rotation);

        }
    }

}
