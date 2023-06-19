using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void prevScene()
    {
        SceneManager.LoadScene(1);
    }

    public void OnVideoUI(GameObject UIVideo)
    {
        UIVideo.SetActive(true);
    }

    public void OffUIDefault(GameObject UIDefault)
    {
        UIDefault.SetActive(false);
    }

    public void OffVideoUI(GameObject UIVideo)
    {
        UIVideo.SetActive(false);
    }

    public void OnUIDefault(GameObject UIDefault)
    {
        UIDefault.SetActive(true);
    }
}
