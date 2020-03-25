using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
// Return from Finger Settings to Main Settings in the menu
public class GoBackFinger : MonoBehaviour
{
    private GameObject Finger;
    private string FingerStr;
    private GameObject Settings;
    private string SettingsStr;

    void Update(){
        FingerStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/Settings/FingerSettings";
        Finger = GameObject.Find(FingerStr);
        SettingsStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/Settings/SettingsItems";
        Settings = GameObject.Find(SettingsStr);
    }
    void OnTriggerEnter(Collider other) {
        //Debug(other.name + " triggered me");

        TriggerDelay td = GameObject.Find("Delay").GetComponent<TriggerDelay>();
        StartCoroutine(td.SetDelay());
        
        Finger.transform.gameObject.SetActive(false);
        Settings.transform.gameObject.SetActive(true);
    }

    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
