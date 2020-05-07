using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Yes on the Yes No Panel
public class Yes : MonoBehaviour
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
            SceneManager.LoadScene("Fail", LoadSceneMode.Additive);
            SceneManager.LoadScene("Fail");
        }
        else if (completion.SceneNotSafe == false){
            completion.SceneSafety = false;
            completion.ShakeAndShout = true;
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
