using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPickup : MonoBehaviour
{
    Transform icon;
    Transform human;
    Transform phone;
    Transform handicon;
    Transform placement;
    Vector3 placementypos;
    Vector3 iconpos;
    GameObject icongo;
    float floatingMax;
    float floatingSpeed;
    void Start()
    {
        icon = GetComponent<Transform>();
        human = GameObject.Find("rp_eric_rigged_001_yup_t").GetComponent<Transform>();
        handicon = GameObject.Find("HandIntro").GetComponent<Transform>();
        phone = GameObject.Find("Phone").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Completion completion = GameObject.Find("Completion").GetComponent<Completion>();
        if (completion.Intro == true){
        IntroIcon();
    }
    if (completion.SceneSafety == true){
        SceneSafetyIcon();
    }
    else if (completion.ShakeAndShout == true){
        ShakeAndShoutIcon();
    }
    else if (completion.CheckForBreathing == true){
        CheckForBreathingIcon();
    }
    else if (completion.CallForHelp == true){
        CallForHelpIcon();
    }
    else if (completion.OpenTheAirway == true){
        OpenTheAirwayIcon();
    }
    else if (completion.PerformCompressionsOnly == true){
        PerformCompressionsOnlyIcon();
    }
    else if (completion.PerformFullCPR == true){
        PerformFullCPRIcon();
    }
    }

    void FixedUpdate(){
        icon.Rotate(0f, 0f, 2f);
    }

    void IntroIcon(){
        // gets the transforms and places the icon
        icon.position = handicon.position;
        placementypos = icon.position;
        placementypos.y += 0.2f;
        icon.position = placementypos;
    }

    void SceneSafetyIcon(){
        // gets the transforms and places the icon
        icon.position = human.position;
        placementypos = icon.position;
        placementypos.y += 0.2f;
        placementypos.x -= 1.5f;
        icon.position = placementypos;
    }

    void ShakeAndShoutIcon(){
        // gets the transforms and places the icon
        icon.position = human.position;
        placementypos = icon.position;
        placementypos.y += 0.2f;
        placementypos.x -= 1.5f;
        icon.position = placementypos;
    }

    void CheckForBreathingIcon(){
        // gets the transforms and places the icon
        icon.position = human.position;
        placementypos = icon.position;
        placementypos.y += 0.2f;
        placementypos.x -= 1.5f;
        icon.position = placementypos;
    }

    void CallForHelpIcon(){
        // gets the transforms and places the icon
        icon.position = phone.position;
        placementypos = icon.position;
        placementypos.y += 0.2f;
        icon.position = placementypos;
        
    }

    void OpenTheAirwayIcon(){
        // gets the transforms and places the icon
        icon.position = human.position;
        placementypos = icon.position;
        placementypos.y += 0.2f;
        placementypos.x -= 1.6f;
        icon.position = placementypos;
        
    }

    void PerformCompressionsOnlyIcon(){
        // gets the transforms and places the icon
        icon.position = human.position;
        placementypos = icon.position;
        placementypos.y += 0.2f;
        placementypos.x -= 1.4f;
        icon.position = placementypos;
        
    }

    void PerformFullCPRIcon(){
        // gets the transforms and places the icon
        icon.position = human.position;
        placementypos = icon.position;
        placementypos.y += 0.2f;
        placementypos.x -= 1.4f;
        icon.position = placementypos;
        
    }
}
