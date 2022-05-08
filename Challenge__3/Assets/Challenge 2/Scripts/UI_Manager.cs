using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{   
    public Text textHealt;
    public Text textScore;
    PlayerControllerX playerController;
    private void Awake()
    {
        
        playerController = FindObjectOfType<PlayerControllerX>();
    }
    // Update is called once per frame
    void Update()
    {
        
        textScore.text ="Score:"+playerController.farmerScore.ToString();
        textHealt.text ="Healt:"+playerController.farmerHealt.ToString();

    }
    
    
}
