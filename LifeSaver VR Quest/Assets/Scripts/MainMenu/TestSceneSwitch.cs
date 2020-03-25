using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Change Scene to Test Scene
public class TestSceneSwitch : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene("Test", LoadSceneMode.Additive);
        SceneManager.LoadScene("Test");
    }
}
