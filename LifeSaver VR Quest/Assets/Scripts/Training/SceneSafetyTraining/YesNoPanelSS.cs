using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class YesNoPanelSS : MonoBehaviour
{
    Text yesnotext;
    Text yestext;
    Text notext;
    GameObject Yes;
    GameObject No;
    GameObject TryAgainGO;
    GameObject MainMenu;
    public string scenesafe;
    CompletionTraining ct;
    void Start()
    {
        yesnotext = GameObject.Find("YesNoPanel/YesNo/YesNo Canvas/YesNoChoices/Explained").GetComponent<Text>();
        Yes = GameObject.Find("YesNoPanel/YesNo/YesNo Canvas/YesNoChoices/YesButton");
        No = GameObject.Find("YesNoPanel/YesNo/YesNo Canvas/YesNoChoices/NoButton");
        TryAgainGO = GameObject.Find("YesNoPanel/YesNo/YesNo Canvas/YesNoChoices/TryAgainButton");
        MainMenu = GameObject.Find("YesNoPanel/YesNo/YesNo Canvas/YesNoChoices/MainMenu");
    }

    void Update()
    {
    ct = GameObject.Find("Completion").GetComponent<CompletionTraining>();
    if (ct.SceneSafety == true){
        YesNoSceneSafety();
    }
    else{
        YesNoNoScene();
    }
    }

    void YesNoSceneSafety(){
    if (ct.SceneNotSafe == true){
        scenesafe="Scene is Safe";
    }
    else if (ct.SceneNotSafe == false){
        scenesafe="Scene is Not Safe";
    }
    if(ct.TryAgain == false){
        yesnotext.text = "Is The Scene Safe ?";
        Yes.SetActive(true);
        No.SetActive(true);
        TryAgainGO.SetActive(false);
        MainMenu.SetActive(false);
    }
    else{
        yesnotext.text = "The " + scenesafe;
        Yes.SetActive(false);
        No.SetActive(false);
        TryAgainGO.SetActive(true);
        MainMenu.SetActive(true);
    }
    }

    void YesNoNoScene(){
    yesnotext.text = "";
    Yes.SetActive(false);
    No.SetActive(false);
    }
}
