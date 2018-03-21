using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;
// using Valve.VR.InteractionSystem.Hand;

public class TextPromptScript : MonoBehaviour {



    public Hand hand1;
    public Hand hand2;
    public Text text;
    public SteamVR_LaserPointer hand1laser;


	// Use this for initialization
	void Start () {
        text.text = "Aksel er søt";
        
	}
	
    void setText(string newText)
    {
        text.text = newText;
    }

	// Update is called once per frame
	void Update () {
        if (hand1.currentAttachedObject == null && hand2.currentAttachedObject == null)
        {
            text.text = "Pick up the Air TankPick up the Air Tank awdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd";
        }
        else if (hand1.currentAttachedObject.gameObject.tag == "AirTank" || hand2.currentAttachedObject.gameObject.tag == "AirTank")
        {
            text.text = "Good job! Put it back.";
        }
        else
        {
            text.text = "Pick up the Air Tank awdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd";
        }



    }
}
