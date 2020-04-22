using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // public static int ScoreNum;
    Text txt;

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int ScoreNum = MunchScript.score;
        txt.text = "Score: " + ScoreNum;
        print(ScoreNum);
    }
}
