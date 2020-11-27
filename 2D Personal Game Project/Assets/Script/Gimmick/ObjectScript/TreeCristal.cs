using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCristal : MonoBehaviour
{
    public Sprite[] Cristal;
    public GameObject tree;
    NumberTree treeScript;
    SpriteRenderer sprite;
    int number;
    private void Start()
    {
        treeScript = tree.GetComponent<NumberTree>();
        sprite = this.GetComponent<SpriteRenderer>();
        sprite.sprite = Cristal[0];
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int rand = Random.Range(0, 4);
        if ((collision.CompareTag("Land") || collision.CompareTag("Rock")) && number == 0)
        {
            treeScript.number++;
            treeScript.light.SetActive(true);
            sprite.sprite = Cristal[rand];
            number = rand;
            Invoke("treeLight", 5f);
        }
        else if (collision.CompareTag("Water") && number == 1)
        {
            sprite.sprite = Cristal[rand];
            treeScript.light.SetActive(true);
            treeScript.number++;
            number = rand;
            Invoke("treeLight", 5f);
        }
        else if (collision.CompareTag("Fire") && number == 2)
        {
            sprite.sprite = Cristal[rand];
            treeScript.light.SetActive(true);
            treeScript.number++;
            number = rand;
            Invoke("treeLight", 5f);
        }
        else if (collision.CompareTag("Wind") && number == 3)
        {
            sprite.sprite = Cristal[rand];
            treeScript.light.SetActive(true);
            treeScript.number++;
            number = rand;
            Invoke("treeLight", 5f);
        }
    }

    void treeLight()
    {
        treeScript.light.SetActive(false);
    }
}
