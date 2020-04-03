using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// Holds code to change the images for every scene
public class Panels : MonoBehaviour
{
    RawImage panelC;
    public Texture Intro;
    public Texture Empty;
    public Texture SceneSafety;
    public Texture ShakeAndShout;
    public Texture CheckForBreathing;
    public Texture CallForHelp;
    public Texture OpenTheAirway;
    public Texture BeginCompressions;
    public Texture BeginFullCPR;
    void Start()
    {
        panelC = GameObject.Find("Level/TV Left/Scene Safety Panel/RawImage").GetComponent<RawImage>();
    }

    public void IntroPanel()
    {
        panelC.texture = Intro;
    }
    public void SceneSafetyPanel()
    {
        panelC.texture = SceneSafety;
    }
    public void ShakeAndShoutPanel()
    {
        panelC.texture = ShakeAndShout;
    }

    public void CheckForBreathingPanel()
    {
        panelC.texture = CheckForBreathing;
    }

    public void CallForHelpPanel()
    {
        panelC.texture = CallForHelp;
    }

    public void OpenTheAirwayPanel()
    {
        panelC.texture = OpenTheAirway;
    }

    public void BeginCompressionsPanel()
    {
        panelC.texture = BeginCompressions;
    }

    public void BeginFullCPRPanel()
    {
        panelC.texture = BeginFullCPR;
    }

    public void EmptyPanel()
    {
        panelC.texture = Empty;
    }
}
