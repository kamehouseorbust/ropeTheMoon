using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockSpawn : MonoBehaviour {

	public GameObject rockPrefab;
	public float timerLength = 0;
	public float minTime = 5;
	public float maxTime = 10;
	private float currentTime = 0;
	private Transform rockSpawnTransform;

	// Use this for initialization
	void Start () {
		rockSpawnTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentTime > timerLength) {
			float spawnY = Random.Range(-1,-4);
			rockSpawnTransform.position = new Vector3 (11.1f,spawnY);
			GameObject.Instantiate (rockPrefab,transform.position, transform.rotation);
			timerLength = Random.Range (minTime, maxTime);
			currentTime = 0;
		}
		currentTime += Time.deltaTime;	
	}
}
