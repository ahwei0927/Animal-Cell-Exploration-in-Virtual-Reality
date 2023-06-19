using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineUI : MonoBehaviour
{
    public GameObject UI;

    private float timeRemaining = 0;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }else
        {
            UI.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
 
        if (other.gameObject.CompareTag("HandDetection"))
        {
            UI.SetActive(true);
            timeRemaining = 90;
        }
    }
}
