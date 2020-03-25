using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
// Controls the scripts used for each step in the test cpr
public class Steps : MonoBehaviour
{

    // Start is called before the first frame update
    void Update()
    {
    Completion completion = GameObject.Find("Completion").GetComponent<Completion>();
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
    void SceneSafety()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Scene Safety " + Environment.NewLine + "Please Ensure That The Scene is Safe " + Environment.NewLine + Environment.NewLine + "If The Scene Is Not Safe Press Not Safe On Your Menu";
    }

    void ShakeAndShout()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Step Two: " + Environment.NewLine + "Shake And Shout " + Environment.NewLine + Environment.NewLine + "Shake the Victim";
    }
    void CheckForBreathing()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Step Three: " + Environment.NewLine + "Check For Breathing " + Environment.NewLine + Environment.NewLine + "Check For Breathing";
    }
    void CallForHelp()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Step Four: " + Environment.NewLine + "Call For Help " + Environment.NewLine + Environment.NewLine + "Call For Help";
    }
    void OpenTheAirway()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Step Five: " + Environment.NewLine + "Open The Airway " + Environment.NewLine + Environment.NewLine + "Open the Airway By Tilting The Head Back When Possible";
    }
    void PerformCompressionsOnly()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Step Six: " + Environment.NewLine + "Perform Compressions Only "+ Environment.NewLine + Environment.NewLine + "Please Perform Compressions Only";
    }
    void PerformFullCPR()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Step Seven: " + Environment.NewLine + "Perform Full CPR "+ Environment.NewLine + Environment.NewLine + "Please Perform Rescue Breaths Followed By Compressions";
    }
    void NoScene()
    {
    Text mytext = GameObject.Find("TV Middle/Text/Text").GetComponent<Text>();
    mytext.text = "Loading Step...";
    }
}
