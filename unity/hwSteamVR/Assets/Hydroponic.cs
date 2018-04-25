using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;


public class Hydroponic : MonoBehaviour
{

    public Transform goal;
    public Hand hand1;
    public Hand hand2;
    public SteamVR_Controller.Device controller;
    public bool closed;
    

    // Use this for initialization
    void Start()
    {
        closed = true;
    }


    // Update is called once per frame
    void Update()
    {

        if (hand1.controller != null && hand2.controller != null) {
            if (hand1.hoveringInteractable != null)
            {
                if (hand1.controller.GetPressUp(SteamVR_Controller.ButtonMask.Trigger) && hand1.hoveringInteractable.gameObject.tag == "Lid")

                {
                    if (closed) {
                        transform.position = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
                        closed = false;
                    } else {
                        transform.position = new Vector3(transform.position.x, transform.position.y - 0.2f, transform.position.z);
                        closed = true;
                    }
                    
                }

            } else if (hand2.hoveringInteractable != null) {
                if (hand2.controller.GetPressUp(SteamVR_Controller.ButtonMask.Trigger) && hand2.hoveringInteractable.gameObject.tag == "Lid")
                {
                    if (closed)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
                        closed = false;
                    }
                    else
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y - 0.2f, transform.position.z);
                        closed = true;
                    }
                }
            }

        }
 /*       if (hand1.hoveringInteractable != null) {
            Debug.Log(hand1.hoveringInteractable.gameObject.tag);
        } */
        

    }
}