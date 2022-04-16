using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text text;
    public InputField InputField;
    //public Slider slider;
    //public Toggle toggle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //text.text ="time " +/*Time*/.time;
        //text.text = "time " + slider.value;
        //if(toggle.isOn)
        //{
        //    text.color = Color.blue;
        //}
        //else
        //{
        //    text.color=Color.red;
        //}

    }

    public void ChangeColor(/*Color color*/)//float a)
    {
        //text.color = Color.blue;
        text.text = InputField.text;
        //Debug.Log(a);
        //text.color = Color.blue;
        // text.text = "time " + slider.value;
    }
}
