using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public int sceneNumber;
    public void MoveScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
    public void TutorialScene()
    {
        SceneManager.LoadScene(1);
    }
}
