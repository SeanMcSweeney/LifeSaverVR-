using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    public Transform text;
    public Transform human;
    public Transform placement;
    public Vector3 placementypos;
    public TextMesh floattxt;
    void Start()
    {
        text = GetComponent<Transform>();
        human = GameObject.Find("rp_eric_rigged_001_yup_t").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Completion completion = GameObject.Find("Completion").GetComponent<Completion>();
        if (completion.Intro == true){
        IntroFT();
    }
    if (completion.SceneSafety == true){
        SceneSafetyFT();
    }
    else if (completion.ShakeAndShout == true){
        ShakeAndShoutFT();
    }
    else if (completion.CheckForBreathing == true){
        CheckForBreathingFT();
    }
    else if (completion.CallForHelp == true){
        CallForHelpFT();
    }
    else if (completion.OpenTheAirway == true){
        OpenTheAirwayFT();
    }
    else if (completion.PerformCompressionsOnly == true){
        PerformCompressionsOnlyFT();
    }
    else if (completion.PerformFullCPR == true){
        PerformFullCPRFT();
    }
    }

    void IntroFT(){
        // gets the transforms and places the text
        text.position = human.position;
        placementypos = text.position;
        placementypos.y += 1;
        placementypos.x -= 2;
        text.position = placementypos;

        // Text Attributes
        floattxt.text = "Place your hands on the icon below to begin";
        floattxt.color = Color.red;

    }

    void SceneSafetyFT(){
        // gets the transforms and places the text
        text.position = human.position;
        placementypos = text.position;
        placementypos.y += 1;
        placementypos.x -= 2;
        text.position = placementypos;

        // Text Attributes
        floattxt.text = "If the scene is safe place your hands on the icon below";
        floattxt.color = Color.red;
        
    }

    void ShakeAndShoutFT(){
        // gets the transforms and places the text
        text.position = human.position;
        placementypos = text.position;
        placementypos.y += 1;
        placementypos.x -= 2;
        text.position = placementypos;

        // Text Attributes
        floattxt.text = "Shake and Shout at the victim to check for a response";
        floattxt.color = Color.red;
    }

    void CheckForBreathingFT(){
        // gets the transforms and places the text
        text.position = human.position;
        placementypos = text.position;
        placementypos.y += 1;
        placementypos.x -= 2;
        text.position = placementypos;

        // Text Attributes
        floattxt.text = "If the scene is safe place your hands on the icon below";
        floattxt.color = Color.red;
        
    }

    void CallForHelpFT(){
        // gets the transforms and places the text
        text.position = human.position;
        placementypos = text.position;
        placementypos.y += 1;
        placementypos.x -= 2;
        text.position = placementypos;

        // Text Attributes
        floattxt.text = "Use the phone to call the emergency services";
        floattxt.color = Color.red;
        
    }

    void OpenTheAirwayFT(){
        // gets the transforms and places the text
        text.position = human.position;
        placementypos = text.position;
        placementypos.y += 1;
        placementypos.x -= 2;
        text.position = placementypos;

        // Text Attributes
        floattxt.text = "Tilt the victims head to open the airway";
        floattxt.color = Color.red;
        
    }

    void PerformCompressionsOnlyFT(){
        // gets the transforms and places the text
        text.position = human.position;
        placementypos = text.position;
        placementypos.y += 1;
        placementypos.x -= 2;
        text.position = placementypos;

        // Text Attributes
        floattxt.text = "Perfrom Compressions at a rate of 100 per minute (Stayin Alive, Bee Gees)";
        floattxt.color = Color.red;
        
    }

    void PerformFullCPRFT(){
        // gets the transforms and places the text
        text.position = human.position;
        placementypos = text.position;
        placementypos.y += 1;
        placementypos.x -= 2;
        text.position = placementypos;

        // Text Attributes
        floattxt.text = "Perfrom 30 Compressions at a rate of 100 per minute (Stayin Alive, Bee Gees) followed by 2 rescue breaths";
        floattxt.color = Color.red;
        
    }
}
