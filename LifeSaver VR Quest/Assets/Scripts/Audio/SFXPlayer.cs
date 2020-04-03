using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    AudioSource PhoneDial;
    AudioSource Pickup;

    GameObject PhoneDialGO;
    GameObject PickupGO;

    void Start()
    {
        // set all gameobjects 
        PhoneDialGO = GameObject.Find("audio/PhoneDial");
        PickupGO = GameObject.Find("audio/Pickup");

        // set all Audio Sources
        PhoneDial = PhoneDialGO.GetComponent<AudioSource>();
        Pickup = PickupGO.GetComponent<AudioSource>();

        SFXOff();
        PhoneDialSFX();
        PickupSFX();
    }

    void SFXOff(){
        PhoneDialGO.SetActive(false);
        PickupGO.SetActive(false);
    }

    void PhoneDialSFX(){
        PhoneDial.priority = 160;
        PhoneDial.playOnAwake = true;
    }

    void PickupSFX(){
        Pickup.priority = 160;
        Pickup.playOnAwake = true;
    }

    public void PlayPhone(){
        PhoneDialGO.SetActive(true);
        PhoneDialGO.SetActive(false);
    }

    public void PlayPickup(){
        PickupGO.SetActive(true);
        PickupGO.SetActive(false);
    }
}

