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

    void Start()
    {
        BGMusic();
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
        Music = GameObject.Find("audio/HospitalAudio").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        Music.volume = PlayerPrefs.GetFloat("volume");
        Music.Play(0);
        Music.loop = true;
    }

    void WelcomeVoice(){
        Welcome = GameObject.Find("audio/Welcome").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        Welcome.volume = PlayerPrefs.GetFloat("volume");
        Welcome.Play(0);
    }

    void SceneSafetyVoice(){
        SceneSafe = GameObject.Find("audio/SceneSafe").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        SceneSafe.volume = PlayerPrefs.GetFloat("volume");
        SceneSafe.Play(0);
    }
    void ShakeAndShoutVoice(){
        Responsive = GameObject.Find("audio/Responsive").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        Responsive.volume = PlayerPrefs.GetFloat("volume");
        Responsive.Play(0);
    }
    void CheckForBreathingVoice(){
        Breathing = GameObject.Find("audio/Breathing").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        Breathing.volume = PlayerPrefs.GetFloat("volume");
        Breathing.Play(0);
    }
    void CallForHelpVoice(){
        CallForHelp = GameObject.Find("audio/CallForHelp").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        CallForHelp.volume = PlayerPrefs.GetFloat("volume");
        CallForHelp.Play(0);
    }
    void OpenTheAirwayVoice(){
        OpenAirway = GameObject.Find("audio/OpenAirway").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        OpenAirway.volume = PlayerPrefs.GetFloat("volume");
        OpenAirway.Play(0);
    }
    void PerformCompressionsOnlyVoice(){
        CompressionsOnly = GameObject.Find("audio/CompressionsOnly").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        CompressionsOnly.volume = PlayerPrefs.GetFloat("volume");
        CompressionsOnly.Play(0);
    }
    void PerformFullCPRVoice(){
        RescueBreaths = GameObject.Find("audio/RescueBreaths").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        RescueBreaths.volume = PlayerPrefs.GetFloat("volume");
        RescueBreaths.Play(0);
    }

    void VolChange(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        Music.volume = PlayerPrefs.GetFloat("volume");
    }
}
