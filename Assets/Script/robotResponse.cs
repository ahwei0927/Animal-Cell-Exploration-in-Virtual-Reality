using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotResponse : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip nucleusClip;
    public AudioClip roughClip;
    public AudioClip smoothClip;
    public AudioClip mitochondriaClip;
    public AudioClip centrioleClip;
    public AudioClip ribosomeClip;
    public AudioClip lysosomeClip;
    public AudioClip membraneClip;
    public AudioClip vacuoleClip;
    public AudioClip golgiClip;
    public AudioClip helloClip;
    public AudioClip sorryClip;

    public void PlaySound(string[] values)
    {

        Debug.Log(values[0]);
        if (values[1] == "hello")
        {
            StopAndPlayClip(helloClip);
            return;
        }
        else if (values[0] == "rough" || values[0] == "RER")
        {
            StopAndPlayClip(roughClip);
            return;
        }
        else if (values[0] == "smooth" || values[0] == "SER")
        {
            StopAndPlayClip(smoothClip);
            return;
        }
        else if (values[0] == "mitochondria" || values[0] == "mito")
        {
            StopAndPlayClip(mitochondriaClip);
            return;
        }
        else if (values[0] == "centriole")
        {
            StopAndPlayClip(centrioleClip);
            return;
        }
        else if (values[0] == "lysosome")
        {
            StopAndPlayClip(lysosomeClip);
            return;
        }
        else if (values[0] == "ribosome")
        {
            StopAndPlayClip(ribosomeClip);
            return;
        }
        else if (values[0] == "cell membrane" || values[0] == "plasma membrane")
        {
            StopAndPlayClip(membraneClip);
            return;
        }
        else if (values[0] == "vacuole")
        {
            StopAndPlayClip(vacuoleClip);
            return;
        }
        else if (values[0] == "golgi" || values[0] == "apparatus")
        {
            StopAndPlayClip(golgiClip);
            return;
        }
        else if (values[0] == "nucleus" || values[0] == "nuclear" || values[0] == "Nicholas")
        {
            StopAndPlayClip(nucleusClip);
            return;
        }
        else
        {
            StopAndPlayClip(sorryClip);
        }
        

        
    }

    private void StopAndPlayClip(AudioClip clip)
    {
        audioSource.Stop();
        audioSource.PlayOneShot(clip);
    }
}
