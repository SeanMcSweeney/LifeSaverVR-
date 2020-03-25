using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
// Script used for Failed level
public class Fail : MonoBehaviour
{
    public int Score;
    void Update()
    {
        Failure();
    }

    void Failure(){
        Text failtxt = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
        failtxt.text = "Unfortunately " + Environment.NewLine + "You have failed " + Environment.NewLine  + "Score: " + Score;
    }
}
