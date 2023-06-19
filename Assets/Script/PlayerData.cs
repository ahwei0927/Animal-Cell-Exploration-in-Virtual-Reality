using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static RoughScore;

public class PlayerData : MonoBehaviour
{
    public APISystem api;
    public Text username;

    void Start()
    {

    }

    public void submitData()
    {
        if (string.IsNullOrEmpty(username.text))
        {
            Debug.Log("Enter your name");
        }
        else
        {
            PlayerPrefs.SetString("username", username.text);
            string name = username.text;
            APISystem api = FindObjectOfType<APISystem>();
            api.Register(name, name, name, name); // Change the value if your alias, fname, lname, and id are different
            
        }
    }

    public void recordScore()
    {
        FindObjectOfType<APISystem>().InsertPlayerActivity(PlayerPrefs.GetString("username"), "R1", "add", getScore().ToString());
    }
}
