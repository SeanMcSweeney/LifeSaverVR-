using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// chains the full congrats animation
// Not Used
public class CongratsAnimations : MonoBehaviour
{
private Animation animation;

    void Start()
    {
        animation = this.GetComponent<Animation>();
        StartingAnimation();
    }

    void Update()
    {
        if (animation.isPlaying){
            return;
        }
        else{
            JumpingAnimation();
        }
    }

    void StartingAnimation(){
        if (animation.isPlaying){
            return;
        }
        else{
            animation.Play("Congrats");
        }
    }

    void JumpingAnimation(){
        if (animation.isPlaying){
            return;
        }
        else{
            animation.Play("Jumping");
        }
    }
}
