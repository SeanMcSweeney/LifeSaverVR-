using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

// Return from Quit Game to Main Menu
public class GoBack : MonoBehaviour
{
    private GameObject MainMenu;
    private string MenuStr;
    private GameObject Quit;
    private string QuitStr;

    void Update(){
        MenuStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/MainMenu";
        MainMenu = GameObject.Find(MenuStr);
        QuitStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu/Menu Canvas/QuitConfirmation";
        Quit = GameObject.Find(QuitStr);
    }
    void OnTriggerEnter(Collider other) {
        //Debug(other.name + " triggered me");

        TriggerDelay td = GameObject.Find("Delay").GetComponent<TriggerDelay>();
        StartCoroutine(td.SetDelay());
        
        MainMenu.transform.gameObject.SetActive(true);
        Quit.transform.gameObject.SetActive(false);
    }

    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
