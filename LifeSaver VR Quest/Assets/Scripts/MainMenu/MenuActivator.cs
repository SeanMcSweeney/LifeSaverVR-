using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
// When the button on the players wrist is pressed the menu will appear
public class MenuActivator : MonoBehaviour
{
    private GameObject Menu;
    private GameObject Arm;
    private string MenuStr;
    private string ArmStr;
    private string TB;
    private bool MenuOpen;
    void Start()
    {
        MenuOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        MenuStr = "HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor/Menu";
        ArmStr = "HandTracking/OVRCameraRig/TrackingSpace/RightHandAnchor/OVRCustomHandPrefab_R/MenuActivator/ArmController";
        Menu = GameObject.Find(MenuStr);
        Arm = GameObject.Find(ArmStr);
        MenuOpener();
        //Debug("placeholder");
    }

    void MenuOpener(){
        if (MenuOpen == false){
            Menu.transform.gameObject.SetActive(false);
        }
        else{
            Menu.transform.gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other) {
        //Debug(other.name + " triggered me");
        if (MenuOpen == true) {
            MenuOpen = false;
        }
        else{
            MenuOpen = true;
        }
    }

    void Debug(String s){
        TB = "/Level/TV Middle/Text/Text";
        Text TextBox = GameObject.Find(TB).GetComponent<Text>();
        TextBox.text = "Menu Open Status " + MenuOpen + Environment.NewLine + s;
    }
}
