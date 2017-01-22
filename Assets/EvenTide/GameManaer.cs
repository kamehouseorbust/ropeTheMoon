using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManaer : MonoBehaviour {

    public static readonly int TITLE = 0;
    public static readonly int GAME = 1;
    public static readonly int END = 2;

    public static int currentState;
    public float fadeTime = 2;
    public bool isFaded = false;
    public Image FadeImg;

	// Use this for initialization
	void Start () {
        currentState = TITLE;
        FadeIn();

	}
	
	// Update is called once per frame
	void Update () {
        
	}


    public static void SwitchState(int newState)
    {
        currentState = newState;

    }

    private void SwitchToGame()
    {

    }

    public void SwitchToEnd()
    {

    }

    public void SwitchToStart()
    {

    }

    public void FadeIn()
    {      
           FadeImg.CrossFadeAlpha(0f, fadeTime, false);
    }
    public void FadeOut()
    {
        FadeImg.CrossFadeAlpha(1f, fadeTime, false);
    }
}
