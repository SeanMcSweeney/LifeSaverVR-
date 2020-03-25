using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Sets the booleans in the triggermanager script if the finger is pressed
// Sets MiddleTrigger to true as Middle was pressed
public class MiddleTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        TriggerManager tm = GameObject.Find("TriggerM").GetComponent<TriggerManager>();
        if (tm.MiddleTrigger == true){
        }
        else{
            tm.MiddleTrigger = true;
            tm.PinkyTrigger = false;
            tm.ThumbTrigger = false;
            tm.RingTrigger = false;
            tm.IndexTrigger = false;
        }
    }
}
