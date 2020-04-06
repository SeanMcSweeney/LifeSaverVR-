using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using System.Net.Sockets;
using System.Threading;
// sends score to premade server
public class SendScore : MonoBehaviour
{
    void ScoreSender(){
        string score = PlayerPrefs.GetInt("FinalScore").ToString();
        int playernum = PlayerPrefs.GetInt("playernum");
        if (playernum == 0){
            PlayerPrefs.SetInt("playernum",1);
        }
        playernum += 1;
        PlayerPrefs.SetInt("playernum",playernum);
        string player = "user" + playernum.ToString();
        string json = @"{'score':'" + score + "', 'player':'"+player+"}";
    }

    void Post(){
        
    }
}
