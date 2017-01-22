using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour {

    // public GameObject waveTracker;
    //   public float speed = .03f;
    public float maxVelocity = 4f;
    public float maxRotation = 30f;
    public float maxDepth = -8f;
    private Rigidbody2D body;
    private bool isJumping = false;

	// Use this for initialization
	void Start () {
        body = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
       body.rotation = Mathf.Clamp((maxRotation * (body.velocity.y / 15)), -maxRotation, maxRotation);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, body.velocity.y - 2f); 
        }
    }
}
