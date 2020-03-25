using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
// Change menu from main menu to quit game confirmation
public class QuitConfirm : MonoBehaviour
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
        
        MainMenu.transform.gameObject.SetActive(false);
        Quit.transform.gameObject.SetActive(true);
    }

    void Debug(String s){
        string TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = s;
    }
}
