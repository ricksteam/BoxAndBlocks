﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBounds : MonoBehaviour {
    Grab left;
    Grab right;

    void Start()
    {
        left = GameObject.Find("hand_left").GetComponent<Grab>();
        right = GameObject.Find("hand_right").GetComponent<Grab>();


    }
	
	void OnTriggerExit(Collider coll)
    {
        left.StopGrabbing();
        right.StopGrabbing();

       
        if (coll.gameObject.name == "Block(Clone)")
        {
            Destroy(coll.gameObject); 
        }
        
    }
}
