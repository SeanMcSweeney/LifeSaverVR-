using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Change Scene to Test Scene
public class TestSceneSwitch : MonoBehaviour
{
    string Test;
    void OnTriggerEnter(Collider other) {
        Test = "Test";
        PlayerPrefs.SetString("SceneName", Test);
        SceneManager.LoadScene("LoadTest", LoadSceneMode.Additive);
        SceneManager.LoadScene("LoadTest");
    }
}
