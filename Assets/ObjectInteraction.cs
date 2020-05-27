using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputSource();
    }

    void CheckInputSource()
    {
        if(OVRInput.GetDown(OVRInput.Button.Any, OVRInput.Controller.LTrackedRemote))
        {
            Debug.Log("Left hand");
        }
        if (OVRInput.GetDown(OVRInput.Button.Any, OVRInput.Controller.RTrackedRemote))
        {
            Debug.Log("Right hand");
        }
    }
}
