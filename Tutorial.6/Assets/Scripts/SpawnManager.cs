using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalsPreFabs;
    private int randomNumber;
    public float startDelay=1f;
    private float spawnInterval = 1f;
    private float xPosionRangeMin = -20f;
    private float xPosionRangeMax = 20f;
    private float zPosionRangeMin = 15f;
    private float zPosionRangeMax = 34f;

    void Start()
    {
        InvokeRepeating("SpawnAnimals", spawnInterval, startDelay);
    }

    // Update is called once per frame
    void Update()   
    {

        //SpawnAnimals();
        
    }
    public void SpawnAnimals()
    {
        
        
            randomNumber = Random.Range(0, animalsPreFabs.Length);
            Vector3 spawnPosition = new Vector3(Random.Range(xPosionRangeMin, xPosionRangeMax), 0f, Random.Range(zPosionRangeMin, zPosionRangeMax));
            Instantiate(animalsPreFabs[randomNumber], spawnPosition, animalsPreFabs[randomNumber].transform.rotation);
            
        
    }
}
