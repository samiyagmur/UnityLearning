using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleton : MonoBehaviour
{
    private static singleton _instance;

    public static singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<singleton>();
                if (_instance==null)
                {
                    _instance = new GameObject("Game Manger").AddComponent<singleton>();
                }
            }
            return _instance;
        }
    }
    public int deger = 15;
    private void Awake()
    {
       if(_instance !=null)
            Destroy(this);
       DontDestroyOnLoad(this);
    }
    
}
class MyClass : MonoBehaviour
{
    //singleton.ýnstance.deger//þeklinde istediðimiz yerde ulaþabiliriz.
}
