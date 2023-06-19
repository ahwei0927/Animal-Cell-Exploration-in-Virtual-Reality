using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitoCollide : MonoBehaviour
{
    public GameObject thirdSphere;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HandDetection") && other.gameObject.CompareTag("Sphere"))
        {
            thirdSphere.SetActive(true);
            Destroy(other.transform.parent.gameObject);

        }
        
    }
}
