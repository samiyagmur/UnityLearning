using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY=30;
    private float startDelay = 1.0f;
    int whichBallsRandom;
    private float SpawnStartValue = 3f;
    private float SpawnEndValue = 5f;
    
    void Start()
    {
        
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(SpawnStartValue, SpawnEndValue));

    }  
    void SpawnRandomBall()
    {        
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        whichBallsRandom = Random.Range(0, ballPrefabs.Length);
        
        Instantiate(ballPrefabs[whichBallsRandom], spawnPos, ballPrefabs[whichBallsRandom].transform.rotation);
    }
    

}
