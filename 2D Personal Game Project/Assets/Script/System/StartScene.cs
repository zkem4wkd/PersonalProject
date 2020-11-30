using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject storyText;
    public void NewGame()
    {
        tutorial.SetActive(true);
    }
    public void LoadGame()
    {
        if(DataController.instance.gameData.storyClear == true)
        {
            SceneManager.LoadScene("Main");
        }
        else
        {
            storyText.SetActive(true);
            Invoke("Delay", 1f);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
    void Delay()
    {
        storyText.SetActive(false);
    }
}
