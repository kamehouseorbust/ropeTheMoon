using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whaleBe : MonoBehaviour {

	private Transform whaleTransform;
	public float whaleSpeed = 1f;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		whaleTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		whaleTransform.Translate (-whaleSpeed*Time.deltaTime, 0, 0);
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
