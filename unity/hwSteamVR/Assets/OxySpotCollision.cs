using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxySpotCollision : MonoBehaviour {

    public bool collided;
    public GameObject OxyTank;
    public Vector3 OxyTankPosition;

	// Use this for initialization
	void Start () {
        collided = false;
        OxyTank = GameObject.Find("OxyTank");
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionStay(Collision collisionInfo)
    {
        // Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        if (collisionInfo.collider.name == "OxyTank")
        {
            collided = true;

        } else
        {
            collided = false;
        }   
    }

 
}
