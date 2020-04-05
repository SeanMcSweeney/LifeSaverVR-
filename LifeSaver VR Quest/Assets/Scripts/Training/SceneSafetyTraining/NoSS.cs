using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Slightly Changed Options For No Training on Panel
public class NoSS : MonoBehaviour
{
    CompletionTraining completion;
    void Start()
    {
        completion = GameObject.Find("Completion").GetComponent<CompletionTraining>();
    }

    void OnTriggerEnter(Collider other) {
    if (completion.SceneSafety == true){
        if (completion.SceneNotSafe == true){
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
            SceneManager.LoadScene("MainMenu");
        }
        else if (completion.SceneNotSafe == false){
            completion.TryAgain = true;
        }
    }
    else{
    }
    }
}
