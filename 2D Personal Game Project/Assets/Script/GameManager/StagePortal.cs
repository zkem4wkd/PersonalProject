using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StagePortal : MonoBehaviour
{
    public Scene nextScene;
    GameController gC;
    private void Start()
    {
        gC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if(nextScene.handle == 9)
            {
                gC.worldTime += 3;
            }
            else
            {
                gC.worldTime += 1;
            }
            gC.Save();
            SceneManager.LoadScene(nextScene.handle);
        }
    }

}
