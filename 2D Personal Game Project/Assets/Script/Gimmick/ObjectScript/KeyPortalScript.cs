using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class KeyPortalScript : MonoBehaviour
{
    GameObject canvas;
    GameObject starKey, moonKey;
    private void Start()
    {
        canvas = this.transform.GetChild(0).gameObject;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            starKey = GameObject.FindGameObjectWithTag("StarKey");
            moonKey = GameObject.FindGameObjectWithTag("MoonKey");
            if (starKey == null || moonKey == null)
            {
                canvas.SetActive(true);
                Invoke("Delay", 2f);
            }
            if (starKey.activeSelf == true && moonKey.activeSelf == true)
            {
                this.GetComponent<PlayableDirector>().Play();
                Destroy(starKey.transform.parent.parent.gameObject);
                Destroy(moonKey.transform.parent.parent.gameObject);
            }
        }
    }
    void Delay()
    {
        canvas.SetActive(false);
    }
}
