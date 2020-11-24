using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfWorld : MonoBehaviour
{
    Vector2 firstPos;
    private void Start()
    {
        firstPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = firstPos;

    }
}
