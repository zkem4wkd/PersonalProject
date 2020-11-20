using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMmanager : MonoBehaviour
{
    GameObject bgmObject;
    private static Dictionary<int, GameObject> _instances = new Dictionary<int, GameObject>();
    public int id;
    public AudioClip[] audios;
    private void Awake()
    {
        if (_instances.ContainsKey(id))
        {
            var existing = _instances[id];
            if (existing != null)
            {
                if (ReferenceEquals(gameObject, existing))
                    return;
                Destroy(gameObject);
                return;
            }
        }
        _instances[id] = gameObject;
        DontDestroyOnLoad(gameObject);
        bgmObject = GameObject.FindGameObjectWithTag("BGM");
        if (bgmObject.GetComponent<BGMmanager>().id != id)
        {
            Destroy(bgmObject);
        }
    }
    private void OnEnable()
    {
        GameController gC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        if (gC.worldTime > 6 && gC.worldTime < 17)
        {
            this.GetComponent<AudioSource>().clip = audios[0];
        }
        else if (gC.worldTime >= 17 && gC.worldTime < 20)
        {
            this.GetComponent<AudioSource>().clip = audios[1];
        }
        else if (gC.worldTime >= 20 || gC.worldTime <= 6)
        {
            this.GetComponent<AudioSource>().clip = audios[2];
        }
        this.GetComponent<AudioSource>().Play();
    }
}
