using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static RoughScore;

public class RoughGameManager : MonoBehaviour
{
    public GameObject canva;
    public GameObject item;
    public GameObject door;
    public AudioSource audioS;
    public AudioClip start;
    public AudioClip end;
    private float elapsedTime = 60f;
    public Text timeText;
    private bool isStart = false;
    private bool hasPlayedEndAudio = false;

    // Update is called once per frame
    void Update()
    {
        if (isStart)
        {
            countTime();
        }

        if (elapsedTime <= 0f || getScore() == 15)
        {
            isStart = false;
            item.SetActive(false);
            door.SetActive(false);

            if (!hasPlayedEndAudio) // Check if the end audio has already been played
            {
                audioS.PlayOneShot(end);
                hasPlayedEndAudio = true; // Set the flag to indicate that the end audio has been played
            }
        }
    }

    public void setStart()
    {
        isStart = true;
        canva.SetActive(false);
        item.SetActive(true);
        audioS.PlayOneShot(start);
    }

    void countTime()
    {
        elapsedTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timeText.text = timeString;
    }
}
