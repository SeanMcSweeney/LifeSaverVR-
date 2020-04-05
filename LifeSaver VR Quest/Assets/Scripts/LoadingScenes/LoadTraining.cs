using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Loads Training after level has loaded and 10 seconds have elapsed
public class LoadTraining : MonoBehaviour
{
    string Level;
    void Start()
    {
        StartCoroutine(LoadAsyncOperation());
    }

    IEnumerator LoadAsyncOperation()
    {
        Level = PlayerPrefs.GetString("SceneName", "SceneSafetyTraining");
        yield return new WaitForSeconds(10); 
        AsyncOperation TestLevel = SceneManager.LoadSceneAsync(Level);
        yield return new WaitForEndOfFrame();
        yield break;
    }
}
