using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Chance to enable scene safety glass
public class EnableSceneSafety : MonoBehaviour
{
    private GameObject GlassGO;
    private string Glass;
    void Update()
    {
        Completion completion = GameObject.Find("Completion").GetComponent<Completion>();
        if (completion.SceneSafety == true){
            if (completion.SceneNotSafe == true){
                Disaster();
            }
        }
    }

    void Disaster(){
        Glass = "Level/Glass";
        GlassGO = GameObject.Find(Glass);
        GlassGO.transform.gameObject.SetActive(true);
    }
}
