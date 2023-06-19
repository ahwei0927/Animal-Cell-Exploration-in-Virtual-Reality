using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongTarget : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip wrong;
    private void OnTriggerEnter(Collider other)
    {
           
        if (other.gameObject.CompareTag("Arrow"))
        {
            audioS.PlayOneShot(wrong);
        }
    }
}
