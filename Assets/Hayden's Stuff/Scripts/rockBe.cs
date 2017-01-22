using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockBe : MonoBehaviour {

	private Transform rockTransform;
	public float rockSpeed = 1f;
	public AudioClip clip;
	private bool hasCollided = false;

	// Use this for initialization
	void Start () {
		rockTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		rockTransform.Translate (-rockSpeed*Time.deltaTime, 0, 0);
	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player" && !hasCollided) {
			AudioSource a = coll.gameObject.GetComponent<AudioSource> ();
			a.PlayOneShot(clip);
			hasCollided = true;
		}
		if (coll.gameObject.tag == "killable") {
			Destroy (this.gameObject);
		}
	}
}
