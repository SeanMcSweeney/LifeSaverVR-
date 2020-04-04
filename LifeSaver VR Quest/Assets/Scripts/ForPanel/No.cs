using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class No : MonoBehaviour
{
    Completion completion;
    void Start()
    {
        completion = GameObject.Find("Completion").GetComponent<Completion>();
    }

    void OnTriggerEnter(Collider other) {
    if (completion.Intro == true){
    }
    if (completion.SceneSafety == true){
        if (completion.SceneNotSafe == true){
            SceneManager.LoadScene("Congrats", LoadSceneMode.Additive);
            SceneManager.LoadScene("Congrats");
        }
        else if (completion.SceneNotSafe == false){
            SceneManager.LoadScene("Fail", LoadSceneMode.Additive);
            SceneManager.LoadScene("Fail");
        }
    }
    else if (completion.ShakeAndShout == true){
    }
    else if (completion.CheckForBreathing == true){
        SceneManager.LoadScene("Fail", LoadSceneMode.Additive);
        SceneManager.LoadScene("Fail");
    }
    else if (completion.CallForHelp == true){
    }
    else if (completion.OpenTheAirway == true){
    }
    else if (completion.PerformCompressionsOnly == true){
    }
    else if (completion.PerformFullCPR == true){
    }
    else{
    }
    }
}
