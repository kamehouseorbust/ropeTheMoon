using System.Collections;
using System.Collections.Generic;
using Water2DTool;
using UnityEngine;

public class WaveGenerator : MonoBehaviour {

    public Transform moon;

    private Water2D_Simulation water;
    public float moonAmplitude = 2.0f;
    public float ampDelta = .05f;
    public float moonMaxAmplitude = 2.0f;
    public float moonMinAmplitude = .25f;

    // Use this for initialization
    void Start()
    {
        water = this.GetComponent<Water2D_Simulation>();
    }

    // Update is called once per frame
    void Update()
    {
         water.sineAmplitudes[0] = moonAmplitude;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow) && moonAmplitude < moonMaxAmplitude)
        {
            moonAmplitude += ampDelta;
            moon.Translate(new Vector3(0f, -2f * ampDelta, 0f));
        }

        if (Input.GetKey(KeyCode.DownArrow) && moonAmplitude > moonMinAmplitude)
        {
            moonAmplitude -= ampDelta;
            moon.Translate(new Vector3( 0f, 2f * ampDelta, 0f));
        }
    }
}
