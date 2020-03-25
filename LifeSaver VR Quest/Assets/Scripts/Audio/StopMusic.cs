using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Stops or starts the background music when the trigger is triggered
public class StopMusic : MonoBehaviour
{
    AudioSource Music;
    string MainMenuStr;
    string TestStr;
    string sceneName;
    Debugger db;
    void Start() {
        Scene scene = SceneManager.GetActiveScene();
        sceneName = scene.name;
        TestStr = "audio/HospitalAudio";
        MainMenuStr = "audio/Loading";
        db = GameObject.Find("Debugger").GetComponent<Debugger>();   
    }
    void OnTriggerEnter(Collider other) {
        //db.Debug("Scene Name = " + sceneName);

        TriggerDelay td = GameObject.Find("Delay").GetComponent<TriggerDelay>();
        StartCoroutine(td.SetDelay());

        if (sceneName == "Test"){
            Music = GameObject.Find(TestStr).GetComponent<AudioSource>();    
            if (Music.isPlaying){
                Music.Stop();
            }
            else{
                Music.Play(0);
                Music.loop = true;
            }
        }
        if (sceneName == "Main Menu"){
        Music = GameObject.Find(MainMenuStr).GetComponent<AudioSource>();   
        if (Music.isPlaying){
                Music.Stop();
            }
            else{
                Music.Play(0);
                Music.loop = true;
            }
        }
    }
}
