using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnCam : MonoBehaviour
{
    WebCamTexture webcamTexture;
    GameObject GO;
    void Start()
    {
        webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }

    void Update()
    {
        
    }
}
