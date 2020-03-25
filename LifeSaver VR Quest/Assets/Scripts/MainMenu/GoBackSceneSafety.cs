using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

// Return from SceneNotSafe to Main Menu

public class GoBackSceneSafety : MonoBehaviour
{
    private GameObject MainMenu;
    private string MenuStr;
    private GameObject SceneNotSafe;
    private string SceneNotSafeStr;

    void Update(){
        MenuStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/MainMenu";
        MainMenu = GameObject.Find(MenuStr);
        SceneNotSafeStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/SceneNotSafeConfirm";
        SceneNotSafe = GameObject.Find(SceneNotSafeStr);
    }
    void OnTriggerEnter(Collider other) {
        //Debug(other.name + " triggered me");

        TriggerDelay td = GameObject.Find("Delay").GetComponent<TriggerDelay>();
        StartCoroutine(td.SetDelay());
        
        MainMenu.transform.gameObject.SetActive(true);
        SceneNotSafe.transform.gameObject.SetActive(false);
    }

    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
