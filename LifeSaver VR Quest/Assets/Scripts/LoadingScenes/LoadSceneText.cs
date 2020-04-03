using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LoadSceneText : MonoBehaviour
{
    string Text;
    string Level;
    
    void Start() {
        Text TextBox = GameObject.Find("Level/TV Middle/Text/Text").GetComponent<Text>();
        Level = PlayerPrefs.GetString("SceneName", "Test");
        Text = "Make Sure You Are Standing On The Red X " + Environment.NewLine + Environment.NewLine + "Loading Scene :" + Level;
        TextBox.text = Text;
    }
}
