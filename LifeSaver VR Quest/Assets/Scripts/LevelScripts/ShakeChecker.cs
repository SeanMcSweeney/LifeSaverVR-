using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Checks to see if the human has been shacked in shake and shout
public class ShakeChecker : MonoBehaviour
{
    GameObject ShoulderLeft;
    GameObject ShoulderRight;
    float counter;
    void Start()
    {
        ShoulderLeft = GameObject.Find("Level/rp_eric_rigged_001_yup_t/root/hip/spine_01/spine_02/spine_03/shoulder_l");
        ShoulderRight = GameObject.Find("Level/rp_eric_rigged_001_yup_t/root/hip/spine_01/spine_02/spine_03/shoulder_r");
    }
    void Update()
    {
        if (ShoulderLeft.GetComponent<OVRGrabbable>().isGrabbed == true){
            counter++;
        }
        if (ShoulderRight.GetComponent<OVRGrabbable>().isGrabbed == true){
            counter++;
        }
        if (counter <= 2){
            Completion completion = GameObject.Find("Completion").GetComponent<Completion>();
            completion.ShakeAndShout = false;
            completion.CheckForBreathing = true;
        }
    }
}
