using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchToGame()
    {
        GameManager.SetScore(0);
        SceneManager.LoadScene("GameScene");
    }

    public void SwitchToEnd()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void SwitchToTitle()
    {
        SceneManager.LoadScene("Eventide");
    }

}
