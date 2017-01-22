using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMoveDisplace : MonoBehaviour {

    private Transform t;
    public float moveSpeed = .1f;

	// Use this for initialization
	void Start () {
        t = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        float vert = Input.GetAxis("Vertical");
        t.Translate(0, vert * moveSpeed * Time.deltaTime, 0);
	}
}
