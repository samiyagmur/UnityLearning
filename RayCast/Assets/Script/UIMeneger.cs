using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMeneger : MonoBehaviour
{
    [SerializeField] List<GameObject> m_List;
    GameObject currentGameObject;
   
    public void OnButtonRightClick()
    {
        currentGameObject = m_List[0];
    }
    public void OnButtonLeftClick()
    {
        currentGameObject = m_List[1];
    }

    public GameObject GetCurrentGameObject()=> currentGameObject;
    
}
