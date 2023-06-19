using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static RoughScore;

public class RoughTrigger : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip point;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            audioS.PlayOneShot(point);
            addScore();
            Destroy(other.gameObject);
        }
    }
}
