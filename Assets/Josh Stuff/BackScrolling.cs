using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScrolling : MonoBehaviour {

    public float scrollSpeed;
    private Material m;

	// Use this for initialization
	void Start () {
        SpriteRenderer rend = this.GetComponent<SpriteRenderer>();
        m = rend.material;
	}
	
	// Update is called once per frame
	void Update () {
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        m.mainTextureOffset = new Vector2(x, 0);
	}
}
