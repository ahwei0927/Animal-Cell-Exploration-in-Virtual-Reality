using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip click;

    public void clickButton()
    {
        audioS.PlayOneShot(click);
    }
}
