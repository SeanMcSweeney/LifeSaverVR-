 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

// Change From Normal Settings To Trigger Finger Settings
public class ChangerTriggerFinger : MonoBehaviour
{
    private GameObject Settings;
    private string SettingsStr;
    private GameObject FingerSettings;
    private string FingerSettingsStr;

    void Update(){
        FingerPath();
    }
    void OnTriggerEnter(Collider other) {
        //Debug(other.name + " triggered me");

        TriggerDelay td = GameObject.Find("Delay").GetComponent<TriggerDelay>();
        StartCoroutine(td.SetDelay());

        Settings.transform.gameObject.SetActive(false);
        FingerSettings.transform.gameObject.SetActive(true);
    }

    void FingerPath(){
        SettingsStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/Settings/SettingsItems";
        FingerSettingsStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/Settings/FingerSettings";
        Settings = GameObject.Find(SettingsStr);
        FingerSettings = GameObject.Find(FingerSettingsStr);
    }

    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
