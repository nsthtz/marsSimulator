using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedCollision : MonoBehaviour
{
    private Hydroponic Hydroponic;
    private Animator anim1;
    private Animator anim2;
    private Animator anim3;
    private bool closed;
    private bool played = false;

    // Use this for initialization
    void Start()
    {
        anim1 = GameObject.Find("cabbage_model").GetComponent<Animator>();
        anim2 = GameObject.Find("cabbage2").GetComponent<Animator>();
        anim3 = GameObject.Find("cabbage3").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Hydroponic = GameObject.Find("Lid").GetComponent<Hydroponic>();
        if (closed && Hydroponic.closed && !played)
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
        Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Seed")
        {
            closed = true;
            
        }
    }
}
    