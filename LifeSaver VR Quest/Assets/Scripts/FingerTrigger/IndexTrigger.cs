using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Sets the booleans in the triggermanager script if the finger is pressed
// Sets IndexTrigger to true as index was pressed
public class IndexTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        TriggerManager tm = GameObject.Find("TriggerM").GetComponent<TriggerManager>();
        if (tm.IndexTrigger == true){
        }
        else{
            tm.IndexTrigger = true;
            tm.PinkyTrigger = false;
            tm.ThumbTrigger = false;
            tm.RingTrigger = false;
            tm.MiddleTrigger = false;
        }
    }
}
