using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Sets the booleans in the triggermanager script if the finger is pressed
// Sets RingTrigger to true as Ring was pressed
public class RingTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        TriggerManager tm = GameObject.Find("TriggerM").GetComponent<TriggerManager>();
        if (tm.RingTrigger == true){
        }
        else{
            tm.RingTrigger = true;
            tm.PinkyTrigger = false;
            tm.ThumbTrigger = false;
            tm.IndexTrigger = false;
            tm.MiddleTrigger = false;
        }
    }
}
