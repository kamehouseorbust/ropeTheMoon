using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveTracker : MonoBehaviour {

    public float moonAmplitude = 2.0f;
    public float ampDelta = .05f;
    private float moonMaxAmplitude = 4.0f;
    private float moonMinAmplitude = .25f;
    private float currentTime = 0f;


	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        float y = (moonAmplitude * Mathf.Sin(2 * currentTime));
        transform.localPosition = new Vector3(this.transform.position.x, y, 0);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow) && moonAmplitude < moonMaxAmplitude)
        {
            moonAmplitude += ampDelta;
        }

        if(Input.GetKey(KeyCode.DownArrow) && moonAmplitude > moonMinAmplitude)
        {
            moonAmplitude -= ampDelta;
        }
    }
}
