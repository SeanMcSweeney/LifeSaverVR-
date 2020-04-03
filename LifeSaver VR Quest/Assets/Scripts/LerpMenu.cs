using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Lerps Menu (Disabled as made menu less smooth)
public class LerpMenu : MonoBehaviour
{
    Transform Current;
    Transform Headset;
    void Start()
    {
        
    }

    void Update()
    {
        Headset = GameObject.Find("HandTracking/OVRCameraRig/TrackingSpace/CenterEyeAnchor").GetComponent<Transform>();
        Current = GetComponent<Transform>();
        transform.localPosition = Vector3.Lerp(Current.position, Headset.position, 2f);
    }
}
