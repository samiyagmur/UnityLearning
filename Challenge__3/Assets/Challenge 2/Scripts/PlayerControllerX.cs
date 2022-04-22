using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerX : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dogPrefab;
    private float fireRate = 1;
    private float nextFire = 0;
    private float horizontalInput;
    public float farmerSpeed = 5f;
    public int healt = 10;
    public Text text;

    public int Healt { get => healt; set => healt = value; }


    // Update is called once per frame


    void Update()
    {   
        text.text = Healt.ToString();
        if (healt==0)
        {
            Debug.Log("Game Over");
            UnityEditor.EditorApplication.isPlaying = false;
        }
        
        
        
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

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

    public void addHealth(int value)
    {
        healt += value;
    }

   
}
