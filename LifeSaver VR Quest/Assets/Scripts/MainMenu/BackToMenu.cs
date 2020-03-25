using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Load Main Menu
public class BackToMenu : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Additive);
        SceneManager.LoadScene("Main Menu");
    }
}
