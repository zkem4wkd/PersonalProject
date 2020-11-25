using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClear : MonoBehaviour
{
    GameData gameData;
    public int stage;
    private void Start()
    {
        if (DataController.instance.gameData.Stage.Length < stage)
        {
            DataController.instance.gameData.Stage = new bool[stage + 1];
        }
        Debug.Log(DataController.instance.gameData.Stage[stage]);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DataController.instance.gameData.Stage[stage] = true;
            Debug.Log(DataController.instance.gameData.Stage[stage]);
        }
    }
}
