using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
// Script used for Congrats level
public class Congrats : MonoBehaviour
{
    public int Score;
    void Update()
    {
        Complete();
    }

    void Complete(){
        Text congratstxt = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
        congratstxt.text = "CONGRATULATIONS " + Environment.NewLine + "YOU PASSED " + Environment.NewLine  + "Score: " + Score;
    }
}
