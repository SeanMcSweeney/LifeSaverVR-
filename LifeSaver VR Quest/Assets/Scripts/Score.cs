using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Tracks the users score in the level
public class Score : MonoBehaviour
{
    public int TotalScore;

    void Start()
    {
        TotalScore = 0;
    }
}
