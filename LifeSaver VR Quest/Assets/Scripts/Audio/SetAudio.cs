using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
// Mixer not used anymore
public class SetAudio : MonoBehaviour
{
    public AudioMixer mixer;

    // Start is called before the first frame update
    void Start()
    {
        AudioListener.volume = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
