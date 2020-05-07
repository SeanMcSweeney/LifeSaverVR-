using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
// Check for Compressions
public class CheckCompressions : MonoBehaviour
{
    Completion completion;
    CompressionCounter CC;
    public int counterCompressions;
    public int rateofCompressions;
    void Start(){
        completion = GameObject.Find("Completion").GetComponent<Completion>();
        CC = GameObject.Find("CompressionsCounter").GetComponent<CompressionCounter>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (completion.PerformFullCPR == true){
        counterCompressions += 1;
        CC.CompressionsCount = counterCompressions;
        }
        else if (completion.PerformCompressionsOnly == true){
        counterCompressions += 1;
        CC.CompressionsCount = counterCompressions;
        }
    }

    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
