using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Debugger : MonoBehaviour
{
    public void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
