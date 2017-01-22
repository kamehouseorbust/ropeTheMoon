using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevels : MonoBehaviour {

    public float waterHeight = 2.0f;
    public float maxWaterHeight = 8f;
    public float minWaterHeight = 2f;
    public float waterDelta = .05f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow) && waterHeight < maxWaterHeight)
        {
            waterHeight += waterDelta;
        }

        if (Input.GetKey(KeyCode.DownArrow) && waterHeight > minWaterHeight)
        {
            waterHeight -= waterDelta;
        }
    }
}
