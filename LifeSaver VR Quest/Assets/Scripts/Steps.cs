using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
// Controls the scripts used for each step in the test cpr
public class Steps : MonoBehaviour
{
    public int compressionsCount;
    public int compressionsRate;
    public int pickupplayercount;
    Completion completion;
    CompressionCounter cc;
    SFXPlayer SFX;
    Score score;
    void Start(){
        cc = GameObject.Find("Completion").GetComponent<CompressionCounter>();
        SFX = GameObject.Find("Completion").GetComponent<SFXPlayer>();
        score = GameObject.Find("Completion").GetComponent<Score>();
    }
    void Update()
    {
    completion = GameObject.Find("Completion").GetComponent<Completion>();
    if (completion.Intro == true){
        SFX.PlayPickup();
        Intro();
    }
    if (completion.SceneSafety == true){
        SFX.PlayPickup();
        SceneSafety();
    }
    else if (completion.ShakeAndShout == true){
        score.TotalScore += 2;
        SFX.PlayPickup();
        ShakeAndShout();
    }
    else if (completion.CheckForBreathing == true){
        score.TotalScore += 2;
        SFX.PlayPickup();
        CheckForBreathing();
    }
    else if (completion.CallForHelp == true){
        score.TotalScore += 2;
        SFX.PlayPickup();
        CallForHelp();
    }
    else if (completion.OpenTheAirway == true){
        score.TotalScore += 2;
        SFX.PlayPickup();
        OpenTheAirway();
    }
    else if (completion.PerformCompressionsOnly == true){
        score.TotalScore += 2;
        SFX.PlayPickup();
        PerformCompressionsOnly();
    }
    else if (completion.PerformFullCPR == true){
        score.TotalScore += 2;
        SFX.PlayPickup();
        PerformFullCPR();
    }
    else{
        NoScene();
    }

    compressionsCount = cc.CompressionsCount;
    compressionsRate = cc.CompressionsRate;
    }

    void Intro()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Please Begin by Placing Your Hands On The Hands Icon ";
    Panels panel = GameObject.Find("Completion").GetComponent<Panels>();
    panel.IntroPanel();
    }
    void SceneSafety()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "If The Scene Is Not Safe Press Not Safe On Your Menu " + Environment.NewLine + Environment.NewLine +  "If The Scene Is Safe Continue Place Your Hands On The Victims Sternum as Shown";
    Panels panel = GameObject.Find("Completion").GetComponent<Panels>();
    panel.SceneSafetyPanel();
    }

    void ShakeAndShout()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Shake the Victim";
    Panels panel = GameObject.Find("Completion").GetComponent<Panels>();
    panel.ShakeAndShoutPanel();
    }
    void CheckForBreathing()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Check For Breathing";
    Panels panel = GameObject.Find("Completion").GetComponent<Panels>();
    panel.CheckForBreathingPanel();
    }
    void CallForHelp()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Call For Help using the phone located under the icon";
    Panels panel = GameObject.Find("Completion").GetComponent<Panels>();
    panel.CallForHelpPanel();
    }
    void OpenTheAirway()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Open the Airway By Tilting The Head Back When Possible";
    Panels panel = GameObject.Find("Completion").GetComponent<Panels>();
    panel.OpenTheAirwayPanel();
    }
    void PerformCompressionsOnly()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Please Perform Compressions Only" + Environment.NewLine + "Total Compressions " + compressionsCount + Environment.NewLine + "Compressions Rate " + compressionsRate;
    Panels panel = GameObject.Find("Completion").GetComponent<Panels>();
    panel.BeginCompressionsPanel();
    }
    void PerformFullCPR()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Please Perform Rescue Breaths Followed By Compressions" + Environment.NewLine + "Total Compressions " + compressionsCount + Environment.NewLine + "Compressions Rate " + compressionsRate;
    Panels panel = GameObject.Find("Completion").GetComponent<Panels>();
    panel.BeginFullCPRPanel();
    }
    void NoScene()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "";
    Panels panel = GameObject.Find("Completion").GetComponent<Panels>();
    panel.IntroPanel();
    }
}
