using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Slider slider;
    public int slide = 20;
    public int power;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("o"))
        {
            slider.value = slider.value + slide;
        }
        if(slider.value < 25)
        {
            power = 1;
            print(power);
        }
        else if (slider.value >25 && slider.value < 50)
        {
            power = 2;
            print(power);
        }
        else if (slider.value > 50 && slider.value < 75)
        {
            power = 3;
            print(power);
        }
        else if (slider.value > 75 && slider.value < 100)
        {
            power = 4;
            print(power);
        }
        slider.value--;

    }
}
