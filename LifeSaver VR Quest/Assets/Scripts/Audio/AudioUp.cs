using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Raises the Audio for each level through the AudioPlayer
public class AudioUp : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        AudioPlayerMainMenu ap = GameObject.Find("AudioManager").GetComponent<AudioPlayerMainMenu>();
        ap.BGvolume = ap.BGvolume + 0.1f;       
    }
}
