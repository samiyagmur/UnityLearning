using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManger : MonoBehaviour
{
    
    DogDetectCollision detectCollision;
    
    public Text healtScore;
    private int healt = 3;
    

    void Start()
    {
        
        healtScore.text = healt.ToString();
        if (transform.position.y < )
        {   
            healt--;
            if (healt==0)
            {
                Debug.Log("Game over");
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
        if (detectCollision.isActiveAndEnabled)
        {
            healt--;
        }
    }

    
    void Update()
    {
        
    }
}
