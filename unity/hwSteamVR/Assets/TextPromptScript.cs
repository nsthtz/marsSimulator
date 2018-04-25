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
    private int state;
    public GameObject OxyTank;
    public GameObject OxySpot;
    public OxySpotCollision OxySpotCollider;
    public GameObject CO2Tank;
    public GameObject COSpot;
    public COSpot COSpotCollider;
    public GameObject WaterTank;
    public GameObject WaterSpot;
    public WaterSpot WaterSpotCollider;
    public GameObject NutriTank;
    public GameObject NutriSpot;
    public NutriSpot NutriSpotCollider;
    public seedCollision BasinCollider;
    public GameObject Button;
    public bool active;
    private Renderer rend; 


	// Use this for initialization
	void Start () {
        text.text = "";
        state = 0;
        OxyTank = GameObject.Find("OxyTank");
        OxySpot = GameObject.Find("OxySpot");
        CO2Tank = GameObject.Find("CO2Tank");
        COSpot = GameObject.Find("COSpot");
        WaterTank = GameObject.Find("WaterTank");
        WaterSpot = GameObject.Find("WaterSpot");
        NutriTank = GameObject.Find("NutriTank");
        NutriSpot = GameObject.Find("NutriSpot");


        Button = GameObject.Find("Button");
        OxySpotCollider = GameObject.Find("OxySpot").GetComponent<OxySpotCollision>();
        COSpotCollider = GameObject.Find("COSpot").GetComponent<COSpot>();
        WaterSpotCollider = GameObject.Find("WaterSpot").GetComponent<WaterSpot>();
        NutriSpotCollider = GameObject.Find("NutriSpot").GetComponent<NutriSpot>();
        BasinCollider = GameObject.Find("Basin").GetComponent<seedCollision>();
        active = false;

        rend = GameObject.Find("Button").GetComponent<Renderer>();
        

    }
	
    void setText(string newText)
    {
        text.text = newText;
    }

    // Update is called once per frame
    void Update() {
        /*    if (hand1.currentAttachedObject == null && hand2.currentAttachedObject == null)
            {
                text.text = "Insert the oxygen tank in the empty space.";
            }
            else if (hand1.currentAttachedObject.gameObject.tag == "AirTank" || hand2.currentAttachedObject.gameObject.tag == "AirTank")
            {
                text.text = "Good job! Put it back.";
            }
            else
            {
                text.text = "Pick up the Air Tank ";
            }

        } */

        switch (state) {

            case 0:

                text.text = "Pick up the purple oxygen tank from the floor and insert it into the hydroponic rack at the highlighted position.";
                // Debug.Log(OxySpotCollider.collided);

                if (OxySpotCollider.collided == true)
                {
                    state = 1;
                    break;
                }

                break;

            case 1:

                text.text = "Good job! A growing plant produces oxygen which will be harvested in this tank. Next we need a carbondioxide tank! Humans make carbon dioxide, that can we can collect and use as 'food' for the plants through photosyntesi. Pick up the red carbondioxide tank from the floor and place it into the hydroponic rack at the highlighted position. ";

                if (COSpotCollider.collided == true)
                {
                    state = 2;
                    break;
                }

                break;

            case 2:

                text.text = "Great! Now pick up the blue water tank and put it in the rack";

                if (WaterSpotCollider.collided == true)
                {
                    state = 3;
                    break;
                }

                break;

            case 3:

                text.text = "A hydroponic system uses water instead of soil, the water is circulated to prevent growth of unwanted bacteria. Normaly a plant pulls nutrients from the soil, in a system like this we need to add the nutrients seperatly. Add the green nutruient tank to the system. ";

                if (NutriSpotCollider.collided == true)
                {
                    state = 4;
                    break;
                }

                break;

            case 4:

                text.text = " Now you are ready to insert the seeds. Open the lid of the Hydroponic system and insert the seed pod.";

                if (BasinCollider.closed == true)
                {
                    state = 5;
                } 
                break;

            case 5:

                text.text = "Close the lid, the system is now ready to be turned on. The seeds will receive nutrition, water and carbondioxide so that they can grow into fertile plants. The oxygen they create through photosynthesis will be gathered in the Oxygen Tank. Press the red button to activate the Hydroponic System";

                if (hand1.controller != null && hand2.controller != null)
                {
                    if (hand1.hoveringInteractable != null)
                    {
                        if (hand1.controller.GetPressUp(SteamVR_Controller.ButtonMask.Trigger) && hand1.hoveringInteractable.gameObject.name == "Button")
                        {
                            
                            if (active == false)
                            {
      
                                active = true;
                                Debug.Log(active);
                                rend.material.shader = Shader.Find("ButtonShader");
                                rend.material.SetColor("_Color", Color.green);
                                state = 6;
                            }
                        }
                    }
                    if (hand2.hoveringInteractable != null)
                    {
                        if (hand2.controller.GetPressUp(SteamVR_Controller.ButtonMask.Trigger) && hand2.hoveringInteractable.gameObject.name == "Button")
                        {
                            
                            if (active == false) {
                                
                                active = true;
                                Debug.Log(active);
                                rend.material.shader = Shader.Find("ButtonShader");
                                rend.material.SetColor("_Color", Color.green);
                                state = 6;
                            }
                            
                        }
                    }
                }

                break;

            case 6:

                text.text = "Well done! The plant is now growing and will be ready for harvest in a couple of days. Feel free to enjoy the scenery while you wait";

                break;

            default:

                text.text = "Well done!";
                break;

        }
        

            

   
              
    }


}
