using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starSpawn : MonoBehaviour {

	public GameObject starPrefab;
	public GameObject ufoPrefab;
	public float timerLength = 0f;
	public float minTime = 5f;
	public float maxTime = 10f;
	private float currentTime = 0;
	private Transform starSpawnTransform;

	// Use this for initialization
	void Start () {
		starSpawnTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentTime > timerLength) {
			float spawnY = Random.Range(1,3);
			starSpawnTransform.position = new Vector3 (10.29f,spawnY);
			int randomObject = Random.Range (1,3);
			if (randomObject == 1) {
				GameObject.Instantiate (starPrefab, transform.position, transform.rotation);
			} else if (randomObject == 2) {
				GameObject.Instantiate (ufoPrefab, transform.position, transform.rotation);
			}
			timerLength = Random.Range (minTime, maxTime);
			currentTime = 0;
		}
		currentTime += Time.deltaTime;
	}
}
