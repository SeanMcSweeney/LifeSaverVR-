using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Checks if the airway has been opened
public class HeadTilted : MonoBehaviour
{
    Completion completion;
    GameObject Head;
    OVRGrabbable HeadG;
    void Start()
    {
        completion = GameObject.Find("Completion").GetComponent<Completion>();
        Head = GameObject.Find("rp_eric_rigged_001_yup_t/root/hip/spine_01/spine_02/spine_03/neck/head");
        HeadG = Head.GetComponent<OVRGrabbable>();
    }
    void Update()
    {
        if (completion.OpenTheAirway == true){
            if (HeadG.isGrabbed){
            completion.OpenTheAirway = false;
            completion.PerformFullCPR = true;
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (completion.OpenTheAirway == true){
            completion.OpenTheAirway = false;
            completion.PerformFullCPR = true;
        }
    }
}
