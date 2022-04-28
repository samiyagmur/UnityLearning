using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text text;
    PlayerControllerX playerController;
    
    
    
    void Start() 
    {
        playerController = FindObjectOfType<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {   
        
        text.text = playerController.farmerHealt.ToString();
    }
    
}
