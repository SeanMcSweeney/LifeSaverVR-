using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

// This Class Checks each finger in finger settings for changes to see if the Trigger Finger is Changed. Default is Index.

public class TriggerManager : MonoBehaviour
{
    public bool IndexTrigger;
    public bool MiddleTrigger;
    public bool RingTrigger;
    public bool PinkyTrigger;
    public bool ThumbTrigger;
    public bool CheckTriggersBool;
    void Start()
    {
        IndexTrigger = true;
        CheckTriggersBool = true;
    }
    void Update() {
        if (CheckTriggersBool == true){
        CheckTriggers();   
        }
    }

    void CheckTriggers(){

        // Set Variables
        string IndexStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_index1/b_l_index2/b_l_index3/l_index_finger_pad_marker/IndexTrigger";
        string PinkyStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_pinky0/b_l_pinky1/b_l_pinky2/b_l_pinky3/l_pinky_finger_tip_marker/PinkyTrigger";
        string ThumbStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_thumb0/b_l_thumb1/b_l_thumb2/b_l_thumb3/l_thumb_finger_tip_marker/ThumbTrigger";
        string RingStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_ring1/b_l_ring2/b_l_ring3/l_ring_finger_tip_marker/RingTrigger";
        string MiddleStr = "HandTracking/OVRCameraRig/TrackingSpace/LeftHandAnchor/OVRCustomHandPrefab_L/OculusHand_L/b_l_wrist/b_l_middle1/b_l_middle2/b_l_middle3/l_middle_finger_tip_marker/MiddleTrigger";
        GameObject Index = GameObject.Find(IndexStr);
        GameObject Pinky = GameObject.Find(PinkyStr);
        GameObject Thumb = GameObject.Find(ThumbStr);
        GameObject Ring = GameObject.Find(RingStr);
        GameObject Middle = GameObject.Find(MiddleStr);

        //Check Triggers For Changes in each Finger
        if (IndexTrigger == true){
        Index.transform.gameObject.SetActive(true);
        Pinky.transform.gameObject.SetActive(false);
        Thumb.transform.gameObject.SetActive(false);
        Ring.transform.gameObject.SetActive(false);
        Middle.transform.gameObject.SetActive(false);
        }

        if (PinkyTrigger == true){
        Pinky.transform.gameObject.SetActive(true);
        Index.transform.gameObject.SetActive(false);
        Thumb.transform.gameObject.SetActive(false);
        Ring.transform.gameObject.SetActive(false);
        Middle.transform.gameObject.SetActive(false);
        }

        if (ThumbTrigger == true){
        Thumb.transform.gameObject.SetActive(true);
        Pinky.transform.gameObject.SetActive(false);
        Index.transform.gameObject.SetActive(false);
        Ring.transform.gameObject.SetActive(false);
        Middle.transform.gameObject.SetActive(false);
        }

        if (RingTrigger == true){
        Ring.transform.gameObject.SetActive(true);
        Pinky.transform.gameObject.SetActive(false);
        Thumb.transform.gameObject.SetActive(false);
        Index.transform.gameObject.SetActive(false);
        Middle.transform.gameObject.SetActive(false);
        }

        if (MiddleTrigger == true){
        Middle.transform.gameObject.SetActive(true);
        Pinky.transform.gameObject.SetActive(false);
        Thumb.transform.gameObject.SetActive(false);
        Ring.transform.gameObject.SetActive(false);
        Index.transform.gameObject.SetActive(false);
        }
    }
}
