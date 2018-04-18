using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpot : MonoBehaviour {

    public bool collided;

    // Use this for initialization
    void Start()
    {
        collided = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        // Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        if (collisionInfo.collider.name == "WaterTank")
        {
            collided = true;

        }
        else
        {
            collided = false;
        }
    }

}
