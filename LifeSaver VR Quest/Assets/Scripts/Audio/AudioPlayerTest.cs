using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Plays Audio for Main Menu

public class AudioPlayerTest : MonoBehaviour
{

    AudioSource Music;
    AudioSource Begin;
    public float BGvolume;
    void Start()
    {
        TestMusic();
        BeginStart();
    }

    // Update is called once per frame
    void Update()
    {
        if (BGvolume != Music.volume){
        VolChange();
        }
    }

    void TestMusic(){
        Music = GameObject.Find("audio/HospitalAudio").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        Music.volume = PlayerPrefs.GetFloat("volume");
        Music.Play(0);
        Music.loop = true;
    }

    void BeginStart(){
        Begin = GameObject.Find("audio/Begin").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        Begin.volume = PlayerPrefs.GetFloat("volume");
        Begin.Play(0);
    }

    void VolChange(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        Music.volume = PlayerPrefs.GetFloat("volume");
    }
}
