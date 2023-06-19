using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NucleusTarget : MonoBehaviour
{
    public Text currentText;
    public Text winText;
    public Text nextText;
    public GameObject currentCube;
    public GameObject nextCube;
    public GameObject currentWrong;
    public GameObject nextWrong;
    public GameObject UIQuestion;
    public GameObject UIWin;
    public AudioSource audioS;
    public AudioClip win;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            audioS.PlayOneShot(win);
            Debug.Log("hit");
            currentText.gameObject.SetActive(false);
            winText.gameObject.SetActive(true);
            StartCoroutine(ShowNextQuestionAfterDelay());
        }
    }

    IEnumerator ShowNextQuestionAfterDelay()
    {
        yield return new WaitForSeconds(5f); // Wait for 5 seconds

        winText.gameObject.SetActive(false); // Hide the win text

        if (nextCube == null && (nextText == null || string.IsNullOrEmpty(nextText.text)))
        {
            UIQuestion.SetActive(false); // Hide the question UI
            UIWin.SetActive(true); // Show the win UI
        }
        else
        {
            if (nextText != null && !string.IsNullOrEmpty(nextText.text))
            {
                nextText.gameObject.SetActive(true); // Show the next question text

                if (nextCube != null)
                {
                    nextCube.SetActive(true); // Show the next cube

                    if (currentCube != null)
                    {
                        currentWrong.SetActive(true); // Hide the current cube
                        nextWrong.SetActive(false);
                        currentCube.SetActive(false);
                    }
                        
                        
                }
            }
        }
    }

}
