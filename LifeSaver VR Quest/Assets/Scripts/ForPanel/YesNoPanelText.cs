using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class YesNoPanelText : MonoBehaviour
{
    Text yesnotext;
    GameObject Yes;
    GameObject No;
    void Start()
    {
        yesnotext = GameObject.Find("YesNoPanel/YesNo/YesNo Canvas/YesNoChoices/Explained").GetComponent<Text>();
        Yes = GameObject.Find("YesNoPanel/YesNo/YesNo Canvas/YesNoChoices/YesButton");
        No = GameObject.Find("YesNoPanel/YesNo/YesNo Canvas/YesNoChoices/NoButton");
    }

    void Update()
    {
    Completion completion = GameObject.Find("Completion").GetComponent<Completion>();
    if (completion.Intro == true){
        YesNoIntro();
    }
    if (completion.SceneSafety == true){
        YesNoSceneSafety();
    }
    else if (completion.ShakeAndShout == true){
        YesNoShakeAndShout();
    }
    else if (completion.CheckForBreathing == true){
        YesNoCheckForBreathing();
    }
    else if (completion.CallForHelp == true){
        YesNoCallForHelp();
    }
    else if (completion.OpenTheAirway == true){
        YesNoOpenTheAirway();
    }
    else if (completion.PerformCompressionsOnly == true){
        YesNoPerformCompressionsOnly();
    }
    else if (completion.PerformFullCPR == true){
        YesNoPerformFullCPR();
    }
    else{
        YesNoNoScene();
    }
    }

    void YesNoIntro(){
    yesnotext.text = "Please Begin by Placing Your Hands On The Hands Icon ";
    Yes.SetActive(false);
    No.SetActive(false);
    }

    void YesNoSceneSafety(){
    yesnotext.text = "Is The Scene Safe ?";
    Yes.SetActive(true);
    No.SetActive(true);
    }

    void YesNoShakeAndShout(){
    yesnotext.text = "Shake and Shout To Check If the Victim Is Responsive ";
    Yes.SetActive(false);
    No.SetActive(false);
    }

    void YesNoCheckForBreathing(){
    yesnotext.text = "Is The Victim Breathing? ";
    Yes.SetActive(true);
    No.SetActive(true);
    }

    void YesNoCallForHelp(){
    yesnotext.text = "Call The Emergency Services Using a Phone ";
    Yes.SetActive(false);
    No.SetActive(false);
    }

    void YesNoOpenTheAirway(){
    yesnotext.text = "Open The Airway By Tilting The Victims Head Back ";
    Yes.SetActive(false);
    No.SetActive(false);
    }

    void YesNoPerformCompressionsOnly(){
    yesnotext.text = "Begin Compressions at a rate of 100 per minute";
    Yes.SetActive(false);
    No.SetActive(false);
    }

    void YesNoPerformFullCPR(){
    yesnotext.text = "Begin 30 Compressions at a rate of 100 per minute followed by 2 rescue breaths and repeat ";
    Yes.SetActive(false);
    No.SetActive(false);
    }

    void YesNoNoScene(){
    yesnotext.text = "";
    Yes.SetActive(false);
    No.SetActive(false);
    }
}
