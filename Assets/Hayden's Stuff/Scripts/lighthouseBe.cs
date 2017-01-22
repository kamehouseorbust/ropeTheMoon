using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighthouseBe : MonoBehaviour {

	private Transform lightHouseTransform;
	public float starSpeed = 1f;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		lightHouseTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		lightHouseTransform.Translate (-starSpeed*Time.deltaTime, 0, 0);
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			AudioSource a = coll.gameObject.GetComponent<AudioSource> ();
			a.PlayOneShot (clip);
			Destroy (this.gameObject);
		}
		if (coll.gameObject.tag == "killable") {
			Destroy (this.gameObject);
		}
	}

}
