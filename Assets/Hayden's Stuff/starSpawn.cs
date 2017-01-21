using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starSpawn : MonoBehaviour {

	public GameObject starPrefab;
	public float timerLength = 2f;
	private float currentTime = 0;
	private Transform starSpawnTransform;

	// Use this for initialization
	void Start () {
		starSpawnTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentTime > timerLength) {
			int spawnY = Random.Range(1,3);
			starSpawnTransform.position = new Vector3 (10.29f,spawnY);
			GameObject.Instantiate (starPrefab,transform.position, transform.rotation);
			currentTime = 0;
		}
		currentTime += Time.deltaTime;
	}
}
