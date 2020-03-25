using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Used to track pair the menu to the vr position (obselete parenting used instead)
public class MenuFollower : MonoBehaviour
{
    private Vector3 menuTransfrom;
    private Vector3 VRTransfrom;
    string VRPath;
    void Start()
    {
        VRPath = "HandTracking/OVRCameraRig";
    }

    void Update()
    {
        MenuPosition();
    }

    void MenuPosition() {
        Transform menuTransform = GameObject.Find("Menu").transform;
        Transform VRTransfrom = GameObject.Find(VRPath).transform;
        Transform FinalPosition = VRTransfrom;

        //Create Menu Position for X, Y and Z
        Vector3 Pos = FinalPosition.position;
        //Pos.x = Pos.x + 0.2f;
        //Pos.z = Pos.z + 0.5f;
        Pos.y = menuTransform.position.y;
        FinalPosition.position = Pos;

        Vector3.Lerp(menuTransform.position, FinalPosition.position, Time.time);
    }
}
