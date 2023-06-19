using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NucleusManager : MonoBehaviour
{
    
    public GameObject question;
    public GameObject item;
    public GameObject UI;



    // Update is called once per frame
    void Update()
    {

    }

    public void setStart()
    {
        
        UI.SetActive(false);
        question.SetActive(true);
        item.SetActive(true);
    }
}
