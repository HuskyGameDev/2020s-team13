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
    public int slide = 10;//20;
    public static int power;
    public Image fill;
    public Color red;
    public Color orange;
    public Color yellow;
    public Color white;

    // Update is called once per frame
    void Update()
    {
    // Checks to see if the O key is pressed, increases the value of the slider's position
        if(Input.GetKeyDown("o"))
        {
            slider.value = slider.value + slide;
        }
   // Constantly checks the slider's value to determine the power level
        if(slider.value < 25)
        {
            power = 1;
            fill.color = white;
            // print(power);
        }
        else if (slider.value >25 && slider.value < 50)
        {
            power = 2;
            fill.color = yellow;
            // fill.color = yellow;
            // print(power);
        }
        else if (slider.value > 50 && slider.value < 75)
        {
            power = 3;
            fill.color = orange;
            // print(power);
        }
        else if (slider.value > 75 && slider.value < 100)
        {
            power = 4;
            fill.color = red;
            // print(power);
        }
 // Adds some challenge to keeping a consistent power level while making it possible to decrease your power
        slider.value--;

    }
}
