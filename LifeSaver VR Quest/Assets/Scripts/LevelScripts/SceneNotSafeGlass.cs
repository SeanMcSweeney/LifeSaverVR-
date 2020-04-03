using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneNotSafeGlass : MonoBehaviour
{
    GameObject Glass;
    void Update()
    {
        Completion completion = GameObject.Find("Completion").GetComponent<Completion>();
        if (completion.SceneNotSafe == true){
        SceneSafetyDropGlass();
        }
    }

    void SceneSafetyDropGlass(){
        Glass = GameObject.Find("Level/Glass");
        Glass.SetActive(true);
    }
}
