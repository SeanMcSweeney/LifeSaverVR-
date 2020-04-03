using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Checks for the scenario and plays the relevant voice clips
public class VoicePlayer : MonoBehaviour
{
    public float BGvolume;
    AudioSource Music;
    AudioSource Welcome;
    AudioSource SceneSafe;
    AudioSource Responsive;
    AudioSource Breathing;
    AudioSource CallForHelp;
    AudioSource OpenAirway;
    AudioSource CompressionsOnly;
    AudioSource RescueBreaths;

    GameObject MusicGO;
    GameObject WelcomeGO;
    GameObject SceneSafeGO;
    GameObject ResponsiveGO;
    GameObject BreathingGO;
    GameObject CallForHelpGO;
    GameObject OpenAirwayGO;
    GameObject CompressionsOnlyGO;
    GameObject RescueBreathsGO;

    void Start()
    {
        if (BGvolume <= 0){
        BGvolume = 1;    
        }
        // set all gameobjects 
        MusicGO = GameObject.Find("audio/HospitalAudio");
        WelcomeGO = GameObject.Find("audio/Begin");
        SceneSafeGO = GameObject.Find("audio/SceneSafe");
        ResponsiveGO = GameObject.Find("audio/Responsive");
        BreathingGO = GameObject.Find("audio/Breathing");
        CallForHelpGO = GameObject.Find("audio/CallForHelp");
        OpenAirwayGO = GameObject.Find("audio/OpenAirway");
        CompressionsOnlyGO = GameObject.Find("audio/CompressionsOnly");
        RescueBreathsGO = GameObject.Find("audio/RescueBreaths");

        // set all Audio Sources
        Music = MusicGO.GetComponent<AudioSource>();
        Welcome = WelcomeGO.GetComponent<AudioSource>();
        SceneSafe = SceneSafeGO.GetComponent<AudioSource>();
        Responsive = ResponsiveGO.GetComponent<AudioSource>();
        Breathing = BreathingGO.GetComponent<AudioSource>();
        CallForHelp = CallForHelpGO.GetComponent<AudioSource>();
        OpenAirway = OpenAirwayGO.GetComponent<AudioSource>();
        CompressionsOnly = CompressionsOnlyGO.GetComponent<AudioSource>();
        RescueBreaths = RescueBreathsGO.GetComponent<AudioSource>();

        BGMusic();
        VoiceOff();
    }

    // Update is called once per frame
    void Update()
    {
        if (BGvolume != Music.volume){
        VolChange();
        }

        Completion completion = GameObject.Find("Completion").GetComponent<Completion>();
        if (completion.Intro == true){
            WelcomeVoice();
        }
        if (completion.SceneSafety == true){
            SceneSafetyVoice();
        }
        else if (completion.ShakeAndShout == true){
            ShakeAndShoutVoice();
        }
        else if (completion.CheckForBreathing == true){
            CheckForBreathingVoice();
        }
        else if (completion.CallForHelp == true){
            CallForHelpVoice();
        }
        else if (completion.OpenTheAirway == true){
            OpenTheAirwayVoice();
        }
        else if (completion.PerformCompressionsOnly == true){
            PerformCompressionsOnlyVoice();
        }
        else if (completion.PerformFullCPR == true){
            PerformFullCPRVoice();
        }
    }

    void BGMusic(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        Music.volume = PlayerPrefs.GetFloat("volume");
        Music.Play();
        Music.loop = true;
    }

    void VoiceOff(){
        WelcomeGO.SetActive(false);
        SceneSafeGO.SetActive(false);
        ResponsiveGO.SetActive(false);
        BreathingGO.SetActive(false);
        CallForHelpGO.SetActive(false);
        OpenAirwayGO.SetActive(false);
        CompressionsOnlyGO.SetActive(false);
        RescueBreathsGO.SetActive(false);
    }

    void WelcomeVoice(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        Welcome.volume = PlayerPrefs.GetFloat("volume");
        Welcome.priority = 160;
        Welcome.playOnAwake = true;
        WelcomeGO.SetActive(true);
    }

    void SceneSafetyVoice(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        SceneSafe.volume = PlayerPrefs.GetFloat("volume");
        SceneSafe.priority = 160;
        SceneSafe.playOnAwake = true;
        SceneSafeGO.SetActive(true);
    }
    void ShakeAndShoutVoice(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        Responsive.volume = PlayerPrefs.GetFloat("volume");
        Responsive.priority = 160;
        Responsive.playOnAwake = true;
        ResponsiveGO.SetActive(true);
    }
    void CheckForBreathingVoice(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        Breathing.volume = PlayerPrefs.GetFloat("volume");
        Breathing.priority = 160;
        Breathing.playOnAwake = true;
        BreathingGO.SetActive(true);
    }
    void CallForHelpVoice(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        CallForHelp.volume = PlayerPrefs.GetFloat("volume");
        CallForHelp.priority = 160;
        CallForHelp.playOnAwake = true;
        SceneSafeGO.SetActive(true);
    }
    void OpenTheAirwayVoice(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        OpenAirway.volume = PlayerPrefs.GetFloat("volume");
        OpenAirway.priority = 160;
        OpenAirway.playOnAwake = true;
        OpenAirwayGO.SetActive(true);
    }
    void PerformCompressionsOnlyVoice(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        CompressionsOnly.volume = PlayerPrefs.GetFloat("volume");
        CompressionsOnly.priority = 160;
        CompressionsOnly.playOnAwake = true;
        CompressionsOnlyGO.SetActive(true);
    }
    void PerformFullCPRVoice(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        RescueBreaths.volume = PlayerPrefs.GetFloat("volume");
        RescueBreaths.priority = 160;
        RescueBreaths.playOnAwake = true;
        RescueBreathsGO.SetActive(true);
    }

    void VolChange(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        Music.volume = PlayerPrefs.GetFloat("volume");
    }
}
