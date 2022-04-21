using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dogPrefab;
    private float fireRate = 1;
    private float nextFire = 0;
    private float horizontalInput;
    public float farmerSpeed = 5f;
    public Vector3 farmerDog;
    

    // Update is called once per frame
    

    void Update()
    {
        farmerDog = transform.position;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(dogPrefab, farmerDog, dogPrefab.transform.rotation);

        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * farmerSpeed);

        if (transform.position.x<8f)
        {
            transform.position = new Vector3(8f, 0f, 0f);
        }
        else if (transform.position.x > 26)
        {
            transform.position = new Vector3(26f, 0f, 0f);
        }
    }

   
}
