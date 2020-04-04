using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Tracks Stages of CPR in Test Level
public class Completion : MonoBehaviour
{
    public bool Intro;
    public bool SceneSafety;
    public bool ShakeAndShout;
    public bool CheckForBreathing;
    public bool CallForHelp;
    public bool OpenTheAirway;
    public bool PerformCompressionsOnly;
    public bool PerformFullCPR;
    public bool SceneNotSafe;

    void Start()
    {
        //SceneNotSafeCheck();
        SceneNotSafe = false;
        Intro = true;
    }
    void SceneNotSafeCheck(){
        // There is a 1/100 chance of the scene being not safe
        int a = Random.Range(1,10);
        int b = Random.Range(1,10);

        if (a == b){
            SceneNotSafe = true;
        }
        else{
            SceneNotSafe = false;
        }
    }
}
