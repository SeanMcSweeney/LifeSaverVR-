using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Change Scene Template To Training Scene
// Not Used
public class TrainingSceneSwitch : MonoBehaviour
{
    string Test;
    void OnTriggerEnter(Collider other) {
        Test = "SceneSafetyTraining";
        PlayerPrefs.SetString("SceneName", Test);
        SceneManager.LoadScene("LoadTraining", LoadSceneMode.Additive);
        SceneManager.LoadScene("LoadTraining");
    }
}
