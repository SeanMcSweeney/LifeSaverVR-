using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueBreathCount : MonoBehaviour
{
    Completion completion;
    CompressionCounter CC;
    public int totalBreaths;
    void Start(){
        completion = GameObject.Find("Completion").GetComponent<Completion>();
        CC = GameObject.Find("Completion").GetComponent<CompressionCounter>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (completion.PerformFullCPR == true){
        totalBreaths += 1;
        }

        if (totalBreaths >= 2){
            CC.rescueBreaths = false;
        }
    }
}
