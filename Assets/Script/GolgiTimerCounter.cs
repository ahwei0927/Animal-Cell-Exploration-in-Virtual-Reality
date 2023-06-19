using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GolgiScore;

public class GolgiTimerCounter : MonoBehaviour
{
    private float elapsedTime = 0f;
    public Text timeText;
    public GameObject canva;
    public GameObject UIWin;
    public GameObject item;
    private bool isStart = false;

    void Update()
    {
        if (isStart)
        {
            countTime();
        }

        if(getScore() == 3f)
        {
            isStart = false;
            UIWin.SetActive(true);
        }
        
    }

    void countTime()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timeText.text = timeString;
        //Debug.Log("Time elapsed: " + timeString);
    }

    public void setStart()
    {
        isStart = true;
        canva.SetActive(false);
        item.SetActive(true);
    }
}

