using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class NumberTree : MonoBehaviour
{
    public Sprite[] numberTree;
    public int number;
    SpriteRenderer tree;
    public GameObject light;
    bool action = false;
    private void Start()
    {
        tree = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        tree.sprite = numberTree[number];
        if(number >= 5 && action == false)
        {
            action = true;
            this.GetComponent<PlayableDirector>().Play(); 
            return;
        }
    }

}
