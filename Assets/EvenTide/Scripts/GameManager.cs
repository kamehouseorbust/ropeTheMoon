using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    private GameManager _instance;
    public GameManager instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameManager();
            return _instance;
        }
    }

    public static int score = 0;

    public static void UpdateScore(int increment)
    {
        score += increment;
    }

    public static void SetScore(int newScore)
    {
        score = newScore;
    }

    public static int GetScore()
    {
        return score;
    }

}
