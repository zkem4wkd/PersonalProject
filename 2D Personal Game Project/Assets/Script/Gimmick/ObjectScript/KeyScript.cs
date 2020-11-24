using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour
{
    public GameObject keyImage;
    private void Awake()
    {
        GameObject starKey = GameObject.Find("KeyPanel").transform.GetChild(0).GetChild(0).gameObject;
        GameObject moonKey = GameObject.Find("KeyPanel").transform.GetChild(0).GetChild(1).gameObject;
        if (this.name == "StarKey" && starKey.activeSelf == true)
        {
            Destroy(this.gameObject);
        }
        if (this.name == "MoonKey" && moonKey.activeSelf == true)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            transform.parent.gameObject.GetComponent<AudioSource>().Play();
            keyImage.gameObject.SetActive(true);
            Destroy(this.gameObject);
            DontDestroyOnLoad(keyImage.transform.parent.transform.parent);
        }
    }
}
