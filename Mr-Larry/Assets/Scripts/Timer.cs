using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float currentTime = 10f;
    float startTime = 60f;

    public Text CountDownText;
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= 1 * Time.deltaTime;
            CountDownText.text = currentTime.ToString ("0");
        }

        if (currentTime >= 10.5f) {CountDownText.color = Color.white;}
        if (currentTime < 10.5f) {CountDownText.color = Color.red;}
    }
}
