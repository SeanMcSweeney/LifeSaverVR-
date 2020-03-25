using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Plays Audio for Main Menu

public class AudioPlayerMainMenu : MonoBehaviour
{

    AudioSource Music;
    AudioSource Welcome;
    public float BGvolume;
    void Start()
    {
        BGvolume = 1f;
        BGMusic();
        WelcomeStart();
    }

    // Update is called once per frame
    void Update()
    {
        if (BGvolume != Music.volume){
        VolChange();
        }
    }

    void BGMusic(){
        Music = GameObject.Find("audio/Loading").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        Music.volume = PlayerPrefs.GetFloat("volume");
        Music.Play(0);
        Music.loop = true;
    }

    void WelcomeStart(){
        Welcome = GameObject.Find("audio/Welcome").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        Welcome.volume = PlayerPrefs.GetFloat("volume");
        Welcome.Play(0);
    }

    void VolChange(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        Music.volume = PlayerPrefs.GetFloat("volume");
    }
}
