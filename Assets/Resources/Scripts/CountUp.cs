using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountUp : MonoBehaviour {
    private int count;  //count of blocks on goal side
	
	void Start () {
        count = 0;  //start at 0
	}

    void Update()
    {
        //display UI each frame
        gameObject.GetComponent<Text>().text = "Count: " + count;
    }
	
	public void setCount(int count)
    {
        this.count = count;
    }

    public void incrementCount()
    {
        count++;
    }
}
