using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Checks to see if the phone is used when the step is call the emergency services
public class CallEMS : MonoBehaviour
{
    Completion completion;
    SFXPlayer sfx;
    void Start()
    {
        completion = GameObject.Find("Completion").GetComponent<Completion>();
        sfx = GameObject.Find("Completion").GetComponent<SFXPlayer>();
    }

    void OnTriggerEnter(Collider other) {
        if (completion.CallForHelp == true){
            sfx.PlayPhone();
            completion.CallForHelp = false;
            completion.OpenTheAirway = true;
        }
    }

}
