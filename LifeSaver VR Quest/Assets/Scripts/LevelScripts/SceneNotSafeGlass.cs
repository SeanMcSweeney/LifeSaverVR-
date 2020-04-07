using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneNotSafeGlass : MonoBehaviour
{
    GameObject Glass;
    void Start() {
        Glass = GameObject.Find("Glass");
        Glass.SetActive(false);
    }
    void Update()
    {
        Completion completion = GameObject.Find("Completion").GetComponent<Completion>();
        if (completion.SceneNotSafe == true){
        SceneSafetyDropGlass();
        }
    }

    void SceneSafetyDropGlass(){
        Glass.SetActive(true);
    }
}
