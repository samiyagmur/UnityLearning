using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogHealtBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Image healtBar;
    private Slider slider;
    DogMovement dogMovement;
    private void Awake()
    {
        slider = FindObjectOfType<Slider>();
        dogMovement = FindObjectOfType<DogMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float healtValue = dogMovement.GetDogCurrentHealt() / dogMovement.GetDogHealt();

        //Debug.Log(healtValue);
        slider.value = healtValue;
    }
}
