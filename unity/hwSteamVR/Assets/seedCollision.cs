using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedCollision : MonoBehaviour
{
    private Hydroponic Hydroponic;
    private Animator anim1;
    private Animator anim2;
    private Animator anim3;
    public bool closed;
    public bool played = false;
    private TextPromptScript textPrompt;
    private bool active;

    // Use this for initialization
    void Start()
    {
        anim1 = GameObject.Find("cabbage_model").GetComponent<Animator>();
        anim2 = GameObject.Find("cabbage2").GetComponent<Animator>();
        anim3 = GameObject.Find("cabbage3").GetComponent<Animator>();
        textPrompt = GameObject.Find("Player").GetComponent<TextPromptScript>();
        active = false;
    }

    // Update is called once per frame
    void Update()
    {

        Hydroponic = GameObject.Find("Lid").GetComponent<Hydroponic>();
        // Debug.Log(closed + " " + textPrompt.active + " ");
        if (closed && textPrompt.active && !played)
        {
            
            anim1.SetTrigger("GoCabbage");
            anim2.SetTrigger("GoCabbage");
            anim3.SetTrigger("GoCabbage");
            played = true;
            Debug.Log("yay");
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
     //   Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Seed")
        {
            closed = true;
            
        }
    }
}
    