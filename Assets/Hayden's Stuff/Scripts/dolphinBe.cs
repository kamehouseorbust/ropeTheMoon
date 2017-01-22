using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dolphinBe : MonoBehaviour {

	private Transform dolphinTransform;
	public float dolphinSpeed = 1f;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		dolphinTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		dolphinTransform.Translate (-dolphinSpeed*Time.deltaTime, 0, 0);
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			AudioSource a = coll.gameObject.GetComponent<AudioSource> ();
			a.PlayOneShot(clip);
			Destroy (this.gameObject);
		}
		if (coll.gameObject.tag == "killable") {
			Destroy (this.gameObject);
		}
	}
}
