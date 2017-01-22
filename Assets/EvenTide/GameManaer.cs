using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManaer : MonoBehaviour {

    public static readonly int TITLE = 0;
    public static readonly int GAME = 1;
    public static readonly int END = 2;

    public static int currentState;
    public static int score;
    
    

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
	}

	
	// Update is called once per frame
	void Update () {
        
	}



    public static void SwitchToGame()
    {
        score = 0;
        SceneManager.LoadScene("GameScene");
    }

    public static void SwitchToEnd()
    {
        SceneManager.LoadScene("End");
    }

    public static void SwitchToStart()
    {
        SceneManager.LoadScene("EvenTide");
    }

    /*public void FadeIn()
    {      
        FadeImg.CrossFadeAlpha(0f, fadeTime, false);
    }
    public void FadeOut()
    {
        FadeImg.CrossFadeAlpha(1f, fadeTime, false);
    }
    public void AlphaOut(Canvas c)
    {
        c.gameObject.SetActive(false);
    }
    public void AlphaIn(Canvas c)
    {
        c.gameObject.SetActive(true);
    }

    IEnumerator Delay(float s)
    {
        yield return new WaitForSeconds(s);
    }
    */
}
