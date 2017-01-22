using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovementtest : MonoBehaviour {
	private Transform playerTransform;
	public ParticleSystem particleEffects;
	public float speed = .5f;

	// Use this for initialization
	void Start () {
		playerTransform = GetComponent<Transform> ();
		particleEffects = GetComponent<ParticleSystem> ();
		particleEffects.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.X)) {
			playerTransform.Translate (0, speed*Time.deltaTime, 0);
		}
		else if(Input.GetKey (KeyCode.Z)){
			playerTransform.Translate (0, -speed* Time.deltaTime, 0);
		}
	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "star") {
			particleEffects.startColor = new Color(225,249,0);
			particleEffects.Play ();
		}
		if (coll.gameObject.tag == "rock") {
			particleEffects.startColor = new Color(255,0,0);
			particleEffects.Play ();
		}
	}
}
