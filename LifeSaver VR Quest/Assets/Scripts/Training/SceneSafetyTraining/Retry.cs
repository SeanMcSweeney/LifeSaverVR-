using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Retries the Training Scene
public class Retry : MonoBehaviour
{      
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("SceneSafetyTraining", LoadSceneMode.Additive);
        SceneManager.LoadScene("SceneSafetyTraining");
    }
}
