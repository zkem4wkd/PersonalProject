using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataController.instance.gameData.storyClear = false;
        for(int i = 0; i < DataController.instance.gameData.Stage.Length; i++)
        {
            DataController.instance.gameData.Stage[i] = false;
        }
    }

}
