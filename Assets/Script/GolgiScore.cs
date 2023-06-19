using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GolgiScore : MonoBehaviour
{
    static float _score;
    public Text scoreText;

    void Update()
    {
        UpdateScoreText();
    }

    public static float getScore() { return _score; }

    public static void addScore()
    {
        _score++;
        Debug.Log(_score);
    }

    public static void minusScore()
    {
        _score--;
        Debug.Log(_score);
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + _score.ToString();
        
    }

    
}
