using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerRed : MonoBehaviour
{
    public GameObject camRedPlayer;

    public bool v1CamPosison;
    public bool v2CamPosison;



    private Vector3 offset;
    

    

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        v1CamPosison = Input.GetKey(KeyCode.V);
        v2CamPosison = Input.GetKey(KeyCode.B);

        if (v1CamPosison)
        {
            offset = new Vector3(1f, 3f, -10f);
            transform.position = camRedPlayer.transform.position + offset;
            transform.rotation = camRedPlayer.transform.rotation;
        }
        else if (v2CamPosison)
        {
            offset = new Vector3(1f, 1.5f, 1f);
            transform.position = camRedPlayer.transform.position + offset;
            transform.rotation = camRedPlayer.transform.rotation;
        }
        else
        {
            transform.position = camRedPlayer.transform.position + offset;
            transform.rotation = camRedPlayer.transform.rotation;
        }

        



    }
}
