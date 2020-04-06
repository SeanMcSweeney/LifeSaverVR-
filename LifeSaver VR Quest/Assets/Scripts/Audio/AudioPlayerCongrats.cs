using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// plays audio on extra levels
public class AudioPlayerCongrats : MonoBehaviour
{
    AudioSource Music;
    AudioSource Welcome;
    public float BGvolume;
    void Start()
    {
        BGvolume = 1f;
        BGMusic();
    }

    // Update is called once per frame
    void Update()
    {
        if (BGvolume != Music.volume){
        VolChange();
        }
    }

    void BGMusic(){
        Music = GameObject.Find("audio/LoadingFireworks").GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("volume", BGvolume);
        Music.volume = PlayerPrefs.GetFloat("volume");
        Music.Play(0);
        Music.loop = true;
    }

    void VolChange(){
        PlayerPrefs.SetFloat("volume", BGvolume);
        Music.volume = PlayerPrefs.GetFloat("volume");
    }
}
