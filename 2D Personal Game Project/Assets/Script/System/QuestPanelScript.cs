using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPanelScript : MonoBehaviour
{
    public GameObject[] quest;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        quest[0] = this.transform.GetChild(0).gameObject;
    }

}
