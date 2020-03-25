using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
// Used to quit the application
public class QuitScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        //Debug(other.name + " triggered me");
        Application.Quit();
    }

    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
