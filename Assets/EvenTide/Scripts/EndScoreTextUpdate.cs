using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScoreTextUpdate : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text t = this.GetComponent<Text>();
        t.text = "Score: " + GameManager.GetScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
