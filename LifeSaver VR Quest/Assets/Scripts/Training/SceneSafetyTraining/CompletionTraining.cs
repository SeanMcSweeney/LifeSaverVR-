using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Activates Training Level
public class CompletionTraining : MonoBehaviour
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
    public bool TryAgain;
    

    void Start()
    {
        SceneNotSafeCheck();
        SceneSafety = true;
        TryAgain = false;
    }
    void SceneNotSafeCheck(){
        // Greater than 50% chance of scene being not safe
        int a = Random.Range(1,10);
        int b = Random.Range(1,10);

        if (a >= b){
            SceneNotSafe = true;
        }
        else{
            SceneNotSafe = false;
        }
    }
}
