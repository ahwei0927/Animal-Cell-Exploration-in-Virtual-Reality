using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MembraneGameManager : MonoBehaviour
{
    
    public GameObject item;
    public GameObject UI;
    public GameObject virus;


    // Update is called once per frame
    void Update()
    {

    }

    public void setStart()
    {
        
        UI.SetActive(false);   
        item.SetActive(true);
        virus.SetActive(true);
    }
}
