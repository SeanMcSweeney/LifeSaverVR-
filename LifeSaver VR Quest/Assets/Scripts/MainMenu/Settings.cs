using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
// Change from Main Menu to Settings
public class Settings : MonoBehaviour
{
    private GameObject MainMenu;
    private string MenuStr;
    private GameObject SettingsGO;
    private string SettingsStr;
    void Update(){
        MenuStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/MainMenu";
        MainMenu = GameObject.Find(MenuStr);
        SettingsStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/Settings";
        SettingsGO = GameObject.Find(SettingsStr);
    }
    void OnTriggerEnter(Collider other) {
        //Debug(other.name + " triggered me");

        TriggerDelay td = GameObject.Find("Delay").GetComponent<TriggerDelay>();
        StartCoroutine(td.SetDelay());
        
        MainMenu.transform.gameObject.SetActive(false);
        SettingsGO.transform.gameObject.SetActive(true);
    }

    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
