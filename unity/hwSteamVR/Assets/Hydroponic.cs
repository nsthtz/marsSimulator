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

    // Use this for initialization
    void Start()
    {

        Debug.Log(transform.position);

        // transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (controller != null) {
            // if (controller.GetPressDown( ))
            { // if left button pressed...
               /* Ray ray = GetComponent<Camera>().ScreenPointToRay(hand1.transform.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    // the object identified by hit.transform was clicked
                    // do whatever you want
                    transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
                } */
            }

            Debug.Log(controller.GetPressDown( SteamVR_Controller.ButtonMask.Grip));
        }
       
    }
}