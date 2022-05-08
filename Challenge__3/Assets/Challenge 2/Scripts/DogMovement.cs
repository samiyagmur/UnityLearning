using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : MonoBehaviour
{
    public float speed;
    private float dogCurrentHealt=6f;
    private float dogHealt = 10f; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public float GetDogCurrentHealt()
    {
        return dogCurrentHealt;
    }
    public float GetDogHealt()
    {
        return dogHealt;
    }
    public void GetDogCurrentHealtIncrease()
    {
        dogCurrentHealt++;
    }
    public void GetDogCurrentHealtDecrease()
    {
        dogCurrentHealt--;
        Debug.Log(dogCurrentHealt);
    }


}//Köpek yok edildiði için yeni köpeðin caný sýfýrlanarak geliyor.
