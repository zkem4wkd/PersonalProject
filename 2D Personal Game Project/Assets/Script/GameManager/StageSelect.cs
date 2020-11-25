using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelect : MonoBehaviour
{
    public GameObject[] maps;
    int i = 0;
    public GameObject[] clear;
    private void Start()
    {
        for (int i = 0; i < DataController.instance.gameData.Stage.Length; i++)
        {
            if(DataController.instance.gameData.Stage[i] == true)
            {
                clear[i].SetActive(true);
            }
            else
            {
                return;
            }
        }
    }
    public void MapRightChange()
    {
        if (maps.Length <= i + 1)
        {
            return;
        }
        else
        {
            maps[i].SetActive(false);
            maps[i + 1].SetActive(true);
            i++;
        }
    }
    public void MapLeftChange()
    {
        if (0 >= i)
        {
            return;
        }
        else
        {
            maps[i].SetActive(false);
            maps[i - 1].SetActive(true);
            i--;
        }
    }
}
