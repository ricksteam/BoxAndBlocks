using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithCameraOnZ : MonoBehaviour {

    public Camera mainCamera;

	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y, mainCamera.transform.position.z + 0.6f);
        transform.rotation = Quaternion.identity;
	}
}
