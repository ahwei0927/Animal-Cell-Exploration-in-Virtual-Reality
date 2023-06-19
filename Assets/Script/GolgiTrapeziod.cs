using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GolgiScore;

public class GolgiTrapeziod : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip[] sound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trapeziod"))
        {
            audioS.PlayOneShot(sound[0]);
            addScore();
            Destroy(other.gameObject);

        }
        else if (other.gameObject.CompareTag("Sphere") || other.gameObject.CompareTag("Cube"))
        {
            audioS.PlayOneShot(sound[1]);
            minusScore();
            Destroy(other.gameObject);

        }
    }
}
