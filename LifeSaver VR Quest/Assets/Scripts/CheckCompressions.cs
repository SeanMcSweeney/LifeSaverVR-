using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
// Check for Compressions
public class CheckCompressions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Completion completion = GameObject.Find("Completion").GetComponent<Completion>();
        if (completion.PerformFullCPR == true){
        //Debug("Entered");
        }
        else if (completion.PerformCompressionsOnly == true){
        //Debug("Entered");
        }
    }

    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
