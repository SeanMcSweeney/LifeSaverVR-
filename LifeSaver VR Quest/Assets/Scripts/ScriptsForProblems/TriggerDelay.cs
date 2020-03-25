using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

// Script that sets a delay to stop two triggers being triggered at once by using a coroutine wait
// Disables a game object for 2 seconds
public class TriggerDelay : MonoBehaviour
{
    string IndexStr;
    string PinkyStr;
    string ThumbStr;
    string RingStr;
    string MiddleStr;
    GameObject Index;
    GameObject Pinky;
    GameObject Thumb;
    GameObject Ring;
    GameObject Middle;
    public IEnumerator SetDelay(){
        TriggerManager tm = GameObject.Find("TriggerM").GetComponent<TriggerManager>();

        // Set Variables
        IndexStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_index1/b_l_index2/b_l_index3/l_index_finger_pad_marker/IndexTrigger";
        PinkyStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_pinky0/b_l_pinky1/b_l_pinky2/b_l_pinky3/l_pinky_finger_tip_marker/PinkyTrigger";
        ThumbStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_thumb0/b_l_thumb1/b_l_thumb2/b_l_thumb3/l_thumb_finger_tip_marker/ThumbTrigger";
        RingStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_ring1/b_l_ring2/b_l_ring3/l_ring_finger_tip_marker/RingTrigger";
        MiddleStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_middle1/b_l_middle2/b_l_middle3/l_middle_finger_tip_marker/MiddleTrigger";
        Index = GameObject.Find(IndexStr);
        Pinky = GameObject.Find(PinkyStr);
        Thumb = GameObject.Find(ThumbStr);
        Ring = GameObject.Find(RingStr);
        Middle = GameObject.Find(MiddleStr);

        //Check Triggers For Changes in each Finger
        if (tm.IndexTrigger == true){  
            tm.CheckTriggersBool = false;
            Index.transform.gameObject.SetActive(false);
            StartCoroutine(StartTrigger());
            yield break;
            }
        
        if (tm.PinkyTrigger == true){  
            tm.CheckTriggersBool = false;
            Pinky.transform.gameObject.SetActive(false);
            StartCoroutine(StartTrigger());
            yield break;
            }

        if (tm.ThumbTrigger == true){  
            tm.CheckTriggersBool = false;
            Thumb.transform.gameObject.SetActive(false);
            StartCoroutine(StartTrigger());
            yield break;
            }

        if (tm.RingTrigger == true){  
            tm.CheckTriggersBool = false;
            Ring.transform.gameObject.SetActive(false);
            StartCoroutine(StartTrigger());
            yield break;
            }

        if (tm.MiddleTrigger == true){  
            tm.CheckTriggersBool = false;
            Middle.transform.gameObject.SetActive(false);
            StartCoroutine(StartTrigger());
            yield break;
            }
        }
        

        public IEnumerator StartTrigger(){
        TriggerManager tm = GameObject.Find("TriggerM").GetComponent<TriggerManager>();

        // Set Variables
        IndexStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_index1/b_l_index2/b_l_index3/l_index_finger_pad_marker/IndexTrigger";
        PinkyStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_pinky0/b_l_pinky1/b_l_pinky2/b_l_pinky3/l_pinky_finger_tip_marker/PinkyTrigger";
        ThumbStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_thumb0/b_l_thumb1/b_l_thumb2/b_l_thumb3/l_thumb_finger_tip_marker/ThumbTrigger";
        RingStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_ring1/b_l_ring2/b_l_ring3/l_ring_finger_tip_marker/RingTrigger";
        MiddleStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_middle1/b_l_middle2/b_l_middle3/l_middle_finger_tip_marker/MiddleTrigger";
        Index = GameObject.Find(IndexStr);
        Pinky = GameObject.Find(PinkyStr);
        Thumb = GameObject.Find(ThumbStr);
        Ring = GameObject.Find(RingStr);
        Middle = GameObject.Find(MiddleStr);

        //Check Triggers For Changes in each Finger
        if (tm.IndexTrigger == true){
            //Debug("Started + 5");  
            yield return new WaitForSeconds(2);  
            tm.CheckTriggersBool = true;
            Index.transform.gameObject.SetActive(true); 
            yield break;
            }

        if (tm.PinkyTrigger == true){
            yield return new WaitForSeconds(2);  
            tm.CheckTriggersBool = true;
            Pinky.transform.gameObject.SetActive(true);  
            yield break;
            }

        if (tm.ThumbTrigger == true){
            yield return new WaitForSeconds(2);  
            tm.CheckTriggersBool = true;
            Thumb.transform.gameObject.SetActive(true);
            yield break;
            }

        if (tm.RingTrigger == true){
            yield return new WaitForSeconds(2);  
            tm.CheckTriggersBool = true;
            Ring.transform.gameObject.SetActive(true);
            yield break;
            }

        if (tm.MiddleTrigger == true){
            yield return new WaitForSeconds(2);  
            tm.CheckTriggersBool = true;
            Middle.transform.gameObject.SetActive(true); 
            yield break;
            }
        }
    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
} 
