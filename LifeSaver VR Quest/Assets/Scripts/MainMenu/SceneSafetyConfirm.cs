using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

// Change from main menu to Scene Safety confirm

public class SceneSafetyConfirm : MonoBehaviour
{
    private GameObject MainMenu;
    private string MenuStr;
    private GameObject SceneSafetyGO;
    private string SceneSafetyStr;
    void Update(){
        MenuStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/MainMenu";
        MainMenu = GameObject.Find(MenuStr);
        SceneSafetyStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/SceneNotSafeConfirm";
        SceneSafetyGO = GameObject.Find(SceneSafetyStr);
    }
    void OnTriggerEnter(Collider other) {
        //Debug(other.name + " triggered me");

        TriggerDelay td = GameObject.Find("Delay").GetComponent<TriggerDelay>();
        StartCoroutine(td.SetDelay());
        
        MainMenu.transform.gameObject.SetActive(false);
        SceneSafetyGO.transform.gameObject.SetActive(true);
    }

    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
