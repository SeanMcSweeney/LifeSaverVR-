using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Change Scene To Training Scene
public class TrainingSceneSwitch : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene("Test", LoadSceneMode.Additive);
        SceneManager.LoadScene("Test");
    }
}
