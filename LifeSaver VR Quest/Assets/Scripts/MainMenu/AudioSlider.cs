﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
// For changing the audio levels with a controller (obselete)
public class AudioSlider : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
    }


    public void SetLevel (float sliderValue)
    {
	mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }
}
