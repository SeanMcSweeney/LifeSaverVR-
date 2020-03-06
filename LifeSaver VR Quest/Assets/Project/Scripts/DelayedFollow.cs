using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedFollow : MonoBehaviour
{
    
public Transform target;

    void Start()
    {
        transform.parent = target.transform;
    }

    
    void Update()
    {
        transform.parent = target.transform;
    }
}
