using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject whichFollowPlayer;

    private Vector3 offset = new Vector3(0, 5, -7);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {   //We are write this Because Cam need to follow Vehicle
        transform.position = whichFollowPlayer.transform.position + offset;
    }
}
