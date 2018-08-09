using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;
using Valve.VR;
using VRTK;
using Valve.VR.InteractionSystem;
public class testVR : MonoBehaviour {
    public GameObject rightController;
	// Use this for initialization
	void Start () {
        rightController= VRTK_DeviceFinder.GetControllerRightHand();
        Debug.Log(rightController);
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(rightController.transform.position);
        
        if (ViveInput.GetPress(HandRole.RightHand, ControllerButton.Menu))
        {
            Debug.Log("MenuPressed");
        }
        if (ViveInput.GetPressUp(HandRole.RightHand, ControllerButton.Menu))
        {
            Debug.Log("menu press up");
        }
        if (ViveInput.GetPressUp(HandRole.RightHand, ControllerButton.Trigger))
        {
            Debug.Log("trigger press up");
        }

       
    }
    public void Hit()
    {
        Debug.Log("Hit");
    }
}
