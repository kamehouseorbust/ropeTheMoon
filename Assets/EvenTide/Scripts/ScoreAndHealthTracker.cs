using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAndHealthTracker : MonoBehaviour {

    public int maxHealth = 3;
    public int pointsPerItem = 20;
    private int currentHealth;
    private float currentScore;
    public int pointsPerSecond = 3;
    public Text scoreText;
    public GameObject[] hits = new GameObject[3];

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
        currentScore = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        currentScore += pointsPerSecond * Time.deltaTime;
        scoreText.text = "SCORE: " + getScore();
        Debug.Log("Score: " + getScore());
		if(currentHealth <= 0)
        {
            
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "star")
        {
            currentScore += (float)pointsPerItem;
        }
        else if(coll.gameObject.tag != "water")
        {
            currentHealth -= 1;
            Destroy(hits[currentHealth]);
            Debug.Log("Health Lost");
        }
    }

    //Returns the rounded score (for display)
    public int getScore()
    {
        return (int)currentScore;
    }
    public void setScore(float newScore)
    {
        currentScore = newScore;
    }
}
