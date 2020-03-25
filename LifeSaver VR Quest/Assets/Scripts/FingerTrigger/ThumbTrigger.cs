using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Sets the booleans in the triggermanager script if the finger is pressed
// Sets ThumbTrigger to true as Thumb was pressed
public class ThumbTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        TriggerManager tm = GameObject.Find("TriggerM").GetComponent<TriggerManager>();
        if (tm.ThumbTrigger == true){
        }
        else{
            tm.ThumbTrigger = true;
            tm.PinkyTrigger = false;
            tm.IndexTrigger = false;
            tm.RingTrigger = false;
            tm.MiddleTrigger = false;
        }
    }
}
