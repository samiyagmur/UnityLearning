using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDog : MonoBehaviour
{
    
    public GameObject[] dogPrefabs;
    private int whichDogGetToSpawn;
    public Vector3 spawnPos;
    
    private float spawnXPosLeftBorder=10;
    private float spawnXPosRightBorder=30;
    private float spawnYPos=0;
    private float spawnZPos=-30;
    public Vector3 spawnRot;

    void Start()
    {

        InvokeRepeating("SpawnRandomBall", 1f, 0.5f);

    }
    void SpawnRandomBall()
    {
        spawnPos =new Vector3(Random.Range(spawnXPosLeftBorder, spawnXPosRightBorder), spawnYPos, spawnZPos);
        whichDogGetToSpawn =Random.Range(0, dogPrefabs.Length);
        Instantiate(dogPrefabs[whichDogGetToSpawn],spawnPos,Quaternion.Euler(spawnRot));
    }
}
