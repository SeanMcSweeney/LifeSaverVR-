using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
// Check which scenario is active and changes all of the videos to that scenes video
public class VideoOrganiser : MonoBehaviour
{
    public UnityEngine.Video.VideoClip videoClip;
    void Update()
    {
        Completion completion = GameObject.Find("Completion").GetComponent<Completion>();
        if (completion.SceneSafety == true){
        SceneSafetyVideo();
        }
        else if (completion.ShakeAndShout == true){
            ShakeAndShoutVideo();
        }
        else if (completion.CheckForBreathing == true){
            CheckForBreathingVideo();
        }
        else if (completion.CallForHelp == true){
            CallForHelpVideo();
        }
        else if (completion.OpenTheAirway == true){
            OpenTheAirwayVideo();
        }
        else if (completion.PerformCompressionsOnly == true){
            PerformCompressionsOnlyVideo();
        }
        else if (completion.PerformFullCPR == true){
            PerformFullCPRVideo();
        }
        else{
            NoSceneVideo();
        }
    }

    void SceneSafetyVideo(){
            var videoPlayer = GameObject.Find("TV Right/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer2 = GameObject.Find("TV Room/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer3 = GameObject.Find("TV Room 2/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            videoClip = GameObject.Find("videos/FakeNews").GetComponent<UnityEngine.Video.VideoPlayer>().clip;
            videoPlayer.clip = videoClip;
            videoPlayer2.clip = videoClip;
            videoPlayer3.clip = videoClip;
    }

    void ShakeAndShoutVideo(){
            var videoPlayer = GameObject.Find("TV Right/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer2 = GameObject.Find("TV Room/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer3 = GameObject.Find("TV Room 2/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            videoClip = GameObject.Find("videos/FakeNews").GetComponent<UnityEngine.Video.VideoPlayer>().clip;
            videoPlayer.clip = videoClip;
            videoPlayer2.clip = videoClip;
            videoPlayer3.clip = videoClip;
    }

    void CheckForBreathingVideo(){
            var videoPlayer = GameObject.Find("TV Right/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer2 = GameObject.Find("TV Room/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer3 = GameObject.Find("TV Room 2/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            videoClip = GameObject.Find("videos/Compressions").GetComponent<UnityEngine.Video.VideoPlayer>().clip;
            videoPlayer.clip = videoClip;
            videoPlayer2.clip = videoClip;
            videoPlayer3.clip = videoClip;
    }

    void CallForHelpVideo(){
            var videoPlayer = GameObject.Find("TV Right/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer2 = GameObject.Find("TV Room/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer3 = GameObject.Find("TV Room 2/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            videoClip = GameObject.Find("videos/Compressions").GetComponent<UnityEngine.Video.VideoPlayer>().clip;
            videoPlayer.clip = videoClip;
            videoPlayer2.clip = videoClip;
            videoPlayer3.clip = videoClip;
    }

    void OpenTheAirwayVideo(){
            var videoPlayer = GameObject.Find("TV Right/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer2 = GameObject.Find("TV Room/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer3 = GameObject.Find("TV Room 2/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            videoClip = GameObject.Find("videos/Compressions").GetComponent<UnityEngine.Video.VideoPlayer>().clip;
            videoPlayer.clip = videoClip;
            videoPlayer2.clip = videoClip;
            videoPlayer3.clip = videoClip;
    }

    void PerformCompressionsOnlyVideo(){
            var videoPlayer = GameObject.Find("TV Right/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer2 = GameObject.Find("TV Room/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer3 = GameObject.Find("TV Room 2/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            videoClip = GameObject.Find("videos/Compressions").GetComponent<UnityEngine.Video.VideoPlayer>().clip;
            videoPlayer.clip = videoClip;
            videoPlayer2.clip = videoClip;
            videoPlayer3.clip = videoClip;
    }

    void PerformFullCPRVideo(){
            var videoPlayer = GameObject.Find("TV Right/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer2 = GameObject.Find("TV Room/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer3 = GameObject.Find("TV Room 2/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            videoClip = GameObject.Find("videos/Compressions").GetComponent<UnityEngine.Video.VideoPlayer>().clip;
            videoPlayer.clip = videoClip;
            videoPlayer2.clip = videoClip;
            videoPlayer3.clip = videoClip;
    }

    void NoSceneVideo(){
            var videoPlayer = GameObject.Find("TV Right/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer2 = GameObject.Find("TV Room/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            var videoPlayer3 = GameObject.Find("TV Room 2/Video/Panel/Video Player").GetComponent<UnityEngine.Video.VideoPlayer>();
            videoClip = GameObject.Find("videos/FakeNews").GetComponent<UnityEngine.Video.VideoPlayer>().clip;
            videoPlayer.clip = videoClip;
            videoPlayer2.clip = videoClip;
            videoPlayer3.clip = videoClip;
    }
}
