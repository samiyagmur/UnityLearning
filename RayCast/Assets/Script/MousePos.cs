using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class MousePos : MonoBehaviour
{
    Camera mainCam;
    [SerializeField] List<GameObject> prefabs;
    GameObject changabeGameObj;
    Vector3 _mousePos;
    Rigidbody _rb;

    

    private void Start()
    {
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
                Instantiate(changabeGameObj, new Vector3(hit.point.x, hit.point.y+ changabeGameObj.transform.localScale.y/2, hit.point.z),Quaternion.identity);
            }
        }
    }

    public void OnButtonRightClick()
    {
        changabeGameObj = prefabs[0];
    }
    public void OnButtonLeftClick()
    {
        changabeGameObj = prefabs[1];
    }


}
