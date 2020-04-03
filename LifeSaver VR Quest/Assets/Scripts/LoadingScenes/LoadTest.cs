using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// After 10 Seconds Loads Test Level
public class LoadTest : MonoBehaviour
{
    string Level;
    void Start()
    {
        StartCoroutine(LoadAsyncOperation());
    }

    IEnumerator LoadAsyncOperation()
    {
        Level = PlayerPrefs.GetString("SceneName", "Test");
        yield return new WaitForSeconds(10); 
        AsyncOperation TestLevel = SceneManager.LoadSceneAsync(Level);
        yield return new WaitForEndOfFrame();
        yield break;
    }
}
