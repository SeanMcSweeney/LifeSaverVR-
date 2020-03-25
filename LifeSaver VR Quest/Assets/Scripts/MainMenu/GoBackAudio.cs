using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
// Script to return from audio settings to main settings
public class GoBackAudio : MonoBehaviour
{
    private GameObject Audio;
    private string AudioStr;
    private GameObject Settings;
    private string SettingsStr;

    void Update(){
        AudioStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/Settings/AudioSettings";
        Audio = GameObject.Find(AudioStr);
        SettingsStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/Settings/SettingsItems";
        Settings = GameObject.Find(SettingsStr);
    }
    void OnTriggerEnter(Collider other) {
        //Debug(other.name + " triggered me");

        TriggerDelay td = GameObject.Find("Delay").GetComponent<TriggerDelay>();
        StartCoroutine(td.SetDelay());
        
        Audio.transform.gameObject.SetActive(false);
        Settings.transform.gameObject.SetActive(true);
    }

    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
