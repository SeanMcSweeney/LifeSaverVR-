using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// check to make sure the scene is safe when continuing
public class SceneIsSafe : MonoBehaviour
{
    Completion completion;
    void Start()
    {
        completion = GameObject.Find("Completion").GetComponent<Completion>();
    }

    void OnTriggerEnter(Collider other) {
        if (completion.SceneSafety == true){
            if (completion.SceneNotSafe == false){
                completion.SceneSafety = false;
                completion.ShakeAndShout = true;
        }
            else{
            SceneManager.LoadScene("Fail", LoadSceneMode.Additive);
            SceneManager.LoadScene("Fail");
        }
        }
    }
}
