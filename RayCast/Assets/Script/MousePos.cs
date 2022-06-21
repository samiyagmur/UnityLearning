using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MousePos : MonoBehaviour
{
    Camera mainCam;
    Vector3 _mousePos;
    Rigidbody _rb;
    UIMeneger _instance;
   
    
    

    private void Start()
    {   _instance=FindObjectOfType<UIMeneger>(); 
        _rb=GetComponent<Rigidbody>();
        mainCam=Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        SpawnAtMousePos();
    }

    private void SpawnAtMousePos()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {   
            Ray ray=mainCam.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit))
            {
                if (!EventSystem.current.IsPointerOverGameObject())
                {
                    if (_instance.GetCurrentGameObject()!=null)
                    {

                    }
                    
                }
                    
                
            }
        }
    }

    


}
