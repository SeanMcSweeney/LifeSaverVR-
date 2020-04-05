using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Slightly Changed Options For Yes Training on Panel
public class YesSS : MonoBehaviour
{
    CompletionTraining completion;
    void Start()
    {
        completion = GameObject.Find("Completion").GetComponent<CompletionTraining>();
    }

    void OnTriggerEnter(Collider other) {
    if (completion.SceneSafety == true){
        if (completion.SceneNotSafe == true){
            completion.TryAgain = true;
        }
        else if (completion.SceneNotSafe == false){
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
        SceneManager.LoadScene("MainMenu");
        }
    }
    else{
    }
    }
}
