using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    float _timer;
	// Use this for initialization
	void Start () {
        _timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        _timer += Time.deltaTime;
	}
}
