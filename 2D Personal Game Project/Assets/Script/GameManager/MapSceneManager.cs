using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapSceneManager : MonoBehaviour
{
    public int SceneNumber;
    GameController gC;
    public GameObject text;
    private void Start()
    {
        gC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }
    public void MoveScene()
    {
        int worldTime = gC.worldTime;
        if (worldTime > 22 || worldTime < 6)
        {
            text.SetActive(true);
            Invoke("Delay", 3f);
        }
        else
        {
            SceneManager.LoadScene(SceneNumber);
        }
    }

    void Delay()
    {
        text.SetActive(false);
    }
}
