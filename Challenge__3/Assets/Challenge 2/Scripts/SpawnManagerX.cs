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

    //horizantal axis until the player
    public GameObject[] dogPrefabs;
    private int whichDogGetToSpawn;
    private Vector3 spawnPos;
    private Vector3 spawnRot;
    private float spawnXPosLeftBorder = 10;
    private float spawnXPosRightBorder = 30;
    private float spawnYPos = 0;
    private float spawnZPos = -30;
    private float spawnDogStartTime = 1f;
    private float spawnRepeat = 0.5f;

    

    void Start()
    {

        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(SpawnStartValue, SpawnEndValue));
        InvokeRepeating("SpawnRandomDog", spawnDogStartTime, spawnRepeat);
    }  
    void SpawnRandomBall()
    {        
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        whichBallsRandom = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[whichBallsRandom], spawnPos, ballPrefabs[whichBallsRandom].transform.rotation);
    }
    //horizontal axis spawn
    void SpawnRandomDog()
    {
        spawnPos = new Vector3(Random.Range(spawnXPosLeftBorder, spawnXPosRightBorder), spawnYPos, spawnZPos);
        whichDogGetToSpawn = Random.Range(0, dogPrefabs.Length);
        Instantiate(dogPrefabs[whichDogGetToSpawn], spawnPos, Quaternion.Euler(spawnRot));
    }


}
