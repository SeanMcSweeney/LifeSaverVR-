using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScript : MonoBehaviour
{
    Completion completion;
    GameObject HandIntro;
    void Start(){
        completion = GameObject.Find("Completion").GetComponent<Completion>();
        HandIntro = GameObject.Find("Level/HandIntro");

        if (completion.Intro == true){
        HandIntro.SetActive(true);
        }
        else{
        HandIntro.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (completion.Intro == true){
        completion.Intro = false;
        completion.SceneSafety = true;
        HandIntro.SetActive(false);
        }
    }
}
