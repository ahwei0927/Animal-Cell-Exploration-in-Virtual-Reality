using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoughScore : MonoBehaviour
{
    static float _score;
    public Text scoreText;
    public GameObject door;

    public static float getScore() { return _score; }
    void Update()
    {
        UpdateScoreText();
    }

    public static void addScore()
    {
        _score++;
        Debug.Log(_score);
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + _score.ToString() + " / 15";

    }

}
