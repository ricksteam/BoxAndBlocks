using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour {
    public GameObject spawnPoint;
    public Material pressedMat;
    public Material defaultMat;
    public GameObject otherButton;
    public int grabbableLayer;

    void OnTriggerEnter(Collider collider)
    {
        //if collision with hand, change color and enable left/right spawnpoint
        if (collider.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = pressedMat;
            otherButton.gameObject.SetActive(false);
            //wait a second before disabling the button
            Invoke("Pressed", 1);
        }
    }

    //disable pressed button, reset default material, and start block spawning
    private void Pressed()
    {
        this.gameObject.SetActive(false);
        gameObject.GetComponent<MeshRenderer>().material = defaultMat;
        spawnPoint.GetComponent<SpawnBlocks>().StartSpawning(grabbableLayer);
    }
}
