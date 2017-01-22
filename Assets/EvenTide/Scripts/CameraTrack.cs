using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrack : MonoBehaviour {

    public Transform boat;
    private float heightDifference;


	// Use this for initialization
	void Start () {
        heightDifference = this.transform.position.y - boat.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(this.transform.position.x, boat.position.y + heightDifference, this.transform.position.z);
	}
}
