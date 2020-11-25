using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class NpcQuestManager : MonoBehaviour
{
    public int questNumber;
    public GameObject questPanel;

    private void Awake()
    {
        if(DataController.instance.gameData.npcQuest[questNumber] == true)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            return;
        }
    }
    public void OnClick()
    {
        {
            this.GetComponent<PlayableDirector>().Play();
        }
    }

}
