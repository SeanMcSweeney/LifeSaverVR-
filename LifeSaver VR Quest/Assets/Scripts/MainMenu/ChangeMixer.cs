using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
//Change menu from settings to audio settings
public class ChangeMixer : MonoBehaviour
{
    private GameObject Settings;
    private string SettingsStr;
    private GameObject AudioSettings;
    private string AudioSettingsStr;

    void Update(){
        AudioPath();
    }
    void OnTriggerEnter(Collider other) {
        //Debug(other.name + " triggered me");

        TriggerDelay td = GameObject.Find("Delay").GetComponent<TriggerDelay>();
        StartCoroutine(td.SetDelay());

        Settings.transform.gameObject.SetActive(false);
        AudioSettings.transform.gameObject.SetActive(true);
    }

    void AudioPath(){
        SettingsStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/Settings/SettingsItems";
        AudioSettingsStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/Settings/AudioSettings";
        Settings = GameObject.Find(SettingsStr);
        AudioSettings = GameObject.Find(AudioSettingsStr);
    }

    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
