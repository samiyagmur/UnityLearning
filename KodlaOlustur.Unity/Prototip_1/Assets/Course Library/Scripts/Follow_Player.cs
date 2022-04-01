using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Object : MonoBehaviour
{
    public GameObject whichFollowPlayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = whichFollowPlayer.transform.position;
    }
}
