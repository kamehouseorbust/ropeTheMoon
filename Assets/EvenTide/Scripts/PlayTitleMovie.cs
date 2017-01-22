using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTitleMovie : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MovieTexture m = (MovieTexture)(this.GetComponent<RawImage>().mainTexture);
        m.loop = true;
        m.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
