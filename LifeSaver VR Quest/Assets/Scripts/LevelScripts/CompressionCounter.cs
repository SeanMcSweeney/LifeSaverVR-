using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// count compressions and calculate rate
public class CompressionCounter : MonoBehaviour
{
    public float timer;
    public int timerint;
    public bool TimerPaused;
    public bool rescueBreaths;
    public int CompressionsCount;
    public int CompressionsRate;
    public int CompressionsCountFull;
    public int CompressionsRateFull;
    Completion completion;


    void Start()
    {
        completion = GameObject.Find("Completion").GetComponent<Completion>();
        TimerPaused = true;
        rescueBreaths = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerPaused == false){
            if(completion.PerformCompressionsOnly == true){
                CompressionsRateTimer();
            }
            if(completion.PerformFullCPR == true){
                FullCprCompressionsRateTimer();
            }
        }
    }

    void ResetTimer(){
        timer = 0; 
    }

    void FullCprCompressionsRateTimer(){
        timer += Time.deltaTime;
        if (timer > 60){
            ResetTimer();
        }
        if (CompressionsCount % 30 == 0){
            TimerPaused = true;
            CheckForRescueBreaths();
        }
        timerint = Mathf.RoundToInt(timer);
        if (timerint > 0){
        CompressionsRate = CompressionsCount / timerint * 60;
        }
    }

    void CompressionsRateTimer(){
        timer += Time.deltaTime;
        if (timer > 60){
            ResetTimer();
        }
        timerint = Mathf.RoundToInt(timer);
        if (timerint > 0){
        CompressionsRate = CompressionsCount / timerint * 60;
        }
    }

    public void CheckForRescueBreaths(){
        rescueBreaths = true;
        if (rescueBreaths == false){
            TimerPaused = false;
        }
    }
}
