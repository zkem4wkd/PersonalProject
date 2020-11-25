using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public int maxStageNumber;
    public int maxQuestNumber;
    private void Awake()
    {
        if (DataController.instance.gameData.Stage.Length < maxStageNumber)
        {
            bool[] saveClear = new bool[DataController.instance.gameData.Stage.Length];
            int minus = maxStageNumber - DataController.instance.gameData.Stage.Length;
            for (int i = 0; i < DataController.instance.gameData.Stage.Length; i++)
            {
                saveClear[i] = DataController.instance.gameData.Stage[i];
            }
            DataController.instance.gameData.Stage = new bool[maxStageNumber];
            for (int i = 0; i < maxStageNumber - minus; i++)
            {
                DataController.instance.gameData.Stage[i] = saveClear[i];
            }
            return;
        }
        if (DataController.instance.gameData.npcQuest.Length < maxQuestNumber)
        {
            bool[] saveClear = new bool[DataController.instance.gameData.npcQuest.Length];
            int minus = maxQuestNumber - DataController.instance.gameData.npcQuest.Length;
            for (int i = 0; i < DataController.instance.gameData.npcQuest.Length; i++)
            {
                saveClear[i] = DataController.instance.gameData.npcQuest[i];
            }
            DataController.instance.gameData.npcQuest = new bool[maxQuestNumber];
            for (int i = 0; i < maxQuestNumber - minus; i++)
            {
                DataController.instance.gameData.npcQuest[i] = saveClear[i];
            }
            return;
        }
    }
}
