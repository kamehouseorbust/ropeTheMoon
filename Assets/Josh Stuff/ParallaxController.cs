using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxController : MonoBehaviour {

    public float cityScrollSpeed = .05f;
    public float cloud1ScrollSpeed = .05f;
    public float cloud2ScrollSpeed = .05f;
    public Material city;
    public Material cloud1;
    public Material cloud2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float cityX = Mathf.Repeat(Time.time * cityScrollSpeed, 1);
        city.mainTextureOffset = new Vector2(cityX, 0);

        float cloud1X = Mathf.Repeat(Time.time * cloud2ScrollSpeed, 1);
        cloud1.mainTextureOffset = new Vector2(cloud1X, 0);

        float cloud2X = Mathf.Repeat(Time.time * cloud2ScrollSpeed, 1);
        cloud2.mainTextureOffset = new Vector2(cloud2X, 0);
    }
}
