using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Check for Breathing
public class CheckBreathing : MonoBehaviour
{
    Completion completion;

    void Start(){
        completion = GameObject.Find("Completion").GetComponent<Completion>();

    }
    void OnTriggerEnter(Collider other) {
        if (completion.CheckForBreathing == true){
            completion.CheckForBreathing = false;
            completion.CallForHelp = true;
        }
    }
}
