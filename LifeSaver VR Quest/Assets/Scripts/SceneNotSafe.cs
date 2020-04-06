using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Checks if scene not safe is enabled when the scene not safe button is pressed on menu
// if the scene is not safe the player passes the level with 100% as they understood cpr couldnt be performed
// if the scene is safe the player fails and gets a score of 0%
public class SceneNotSafe : MonoBehaviour
{
    private Completion completion;
    Score score;
    void Update()
    {
        completion = GameObject.Find("Completion").GetComponent<Completion>();
        score = GameObject.Find("Completion").GetComponent<Score>();
    }
    void OnTriggerEnter(Collider other) {
        if (completion.SceneNotSafe == true){
            score.TotalScore = 10;
            PlayerPrefs.SetInt("FinalScore", score.TotalScore);
            SceneManager.LoadScene("Congrats", LoadSceneMode.Additive);
            SceneManager.LoadScene("Congrats");
    
        }
        else{
            score.TotalScore = 0;
            PlayerPrefs.SetInt("FinalScore", score.TotalScore);
            SceneManager.LoadScene("Fail", LoadSceneMode.Additive);
            SceneManager.LoadScene("Fail");
        }
    }
}
