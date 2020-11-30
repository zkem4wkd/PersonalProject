using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryClear : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            DataController.instance.gameData.storyClear = true;
        }
    }
}
