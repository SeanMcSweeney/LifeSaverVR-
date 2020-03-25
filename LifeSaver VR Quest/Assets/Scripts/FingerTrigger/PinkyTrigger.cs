using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Sets the booleans in the triggermanager script if the finger is pressed
// Sets PinkyTrigger to true as Pinky was pressed
public class PinkyTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        TriggerManager tm = GameObject.Find("TriggerM").GetComponent<TriggerManager>();
        if (tm.PinkyTrigger == true){
        }
        else{
            tm.PinkyTrigger = true;
            tm.IndexTrigger = false;
            tm.ThumbTrigger = false;
            tm.RingTrigger = false;
            tm.MiddleTrigger = false;
        }
    }
}
