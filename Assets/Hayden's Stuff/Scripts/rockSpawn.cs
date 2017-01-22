using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockSpawn : MonoBehaviour {

	public GameObject rockPrefab;
	public GameObject lightHousePrefab;
	public GameObject whalePrefab;
	public GameObject dolphinePrefab;
	public float timerLength = 0;
	public float minTime = 5;
	public float maxTime = 10;
	public float minHeight;
	public float maxHeight;
	private float currentTime = 0;
	private Transform rockSpawnTransform;

	// Use this for initialization
	void Start () {
		rockSpawnTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentTime > timerLength) {
			float spawnY = Random.Range(minHeight,maxHeight);
			rockSpawnTransform.position = new Vector3 (20.51f,spawnY);
			int rand = Random.Range (1,3);

			if (-2.6 < rockSpawnTransform.position.y && rockSpawnTransform.position.y < 2) {
				if (-1 < rockSpawnTransform.position.y && rockSpawnTransform.position.y < 0) {
					if (rand == 1){ 
						GameObject.Instantiate (dolphinePrefab, transform.position, transform.rotation);
					}
					else if (rand == 2){
						GameObject.Instantiate (lightHousePrefab, transform.position, transform.rotation);
					}
				} else {
					GameObject.Instantiate (lightHousePrefab, transform.position, transform.rotation);
				}
			}


			if (-25 < rockSpawnTransform.position.y && rockSpawnTransform.position.y < -2.3) {
				if (-8 < rockSpawnTransform.position.y && rockSpawnTransform.position.y < -5) {
					if (rand == 1) {
						
					} else if (rand == 2) {
						GameObject.Instantiate (rockPrefab, transform.position, transform.rotation);
					}
				} else if (rockSpawnTransform.position.y > -5) {
					GameObject.Instantiate (whalePrefab, transform.position, transform.rotation);
				} else {
					GameObject.Instantiate (rockPrefab, transform.position, transform.rotation);
				}

			}

			timerLength = Random.Range (minTime, maxTime);
			currentTime = 0;
		}
		currentTime += Time.deltaTime;	
	}
}
