using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerX : MonoBehaviour
{

    public GameObject dogPrefab;
    DestroyOutOfBoundsX destroyOutOfBoundsX;
    DogDetectCollision dogDetectCollision;
    private float fireRate = 1;
    private float nextFire = 0;
    private float horizontalInput;
    public float farmerSpeed = 5f;
    public float farmerHealt = 3f;

    //private bool Ýsde;
    private void Start()
    {   

        
    }
    private void Update()
    {   
        GenereteDogWithPressKey();
        BorderOfPlayer();
        
    }
    void GenereteDogWithPressKey()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * farmerSpeed);

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
    void BorderOfPlayer()
    {
        if (transform.position.x < 8f)
        {
            transform.position = new Vector3(8f, 0f, 0f);
        }
        else if (transform.position.x > 26f)
        {
            transform.position = new Vector3(26f, 0f, 0f);
        }
    }
    public  void DecreaseHealt()
    {
        farmerHealt--;
        if (farmerHealt==0)
        {
            
            Debug.Log("Game Over");
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
    

}
