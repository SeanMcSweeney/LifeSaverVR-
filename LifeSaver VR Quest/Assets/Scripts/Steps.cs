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
    Completion completion;
    void Update()
    {
    completion = GameObject.Find("Completion").GetComponent<Completion>();
    if (completion.Intro == true){
        Intro();
    }
    if (completion.SceneSafety == true){
        SceneSafety();
    }
    else if (completion.ShakeAndShout == true){
        ShakeAndShout();
    }
    else if (completion.CheckForBreathing == true){
        CheckForBreathing();
    }
    else if (completion.CallForHelp == true){
        CallForHelp();
    }
    else if (completion.OpenTheAirway == true){
        OpenTheAirway();
    }
    else if (completion.PerformCompressionsOnly == true){
        PerformCompressionsOnly();
    }
    else if (completion.PerformFullCPR == true){
        PerformFullCPR();
    }
    else{
        NoScene();
    }
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
    mytext.text = "Please Perform Rescue Breaths Followed By Compressions";
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
