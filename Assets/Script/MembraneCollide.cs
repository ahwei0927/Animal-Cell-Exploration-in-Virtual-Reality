using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MembraneCollide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Monster"))
        {
            other.gameObject.SetActive(false);
        }
        
    }
}
