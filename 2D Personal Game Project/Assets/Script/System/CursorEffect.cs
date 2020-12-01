using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorEffect : MonoBehaviour
{
    Vector3 pos;
    public Sprite[] cursors;
    SpriteRenderer sr;
    private void Start()
    {
        sr = this.GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(pos.x, pos.y, 0);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Land"))
        {
            sr.sprite = cursors[0];
        }
        if (collision.CompareTag("Water"))
        {
            sr.sprite = cursors[1];
        }
        if (collision.CompareTag("Fire"))
        {
            sr.sprite = cursors[2];
        }
        if (collision.CompareTag("Wind"))
        {
            sr.sprite = cursors[3];
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Land"))
        {
            sr.sprite = cursors[4];
        }
        if (collision.CompareTag("Water"))
        {
            sr.sprite = cursors[4];
        }
        if (collision.CompareTag("Fire"))
        {
            sr.sprite = cursors[4];
        }
        if (collision.CompareTag("Wind"))
        {
            sr.sprite = cursors[4];
        }
    }
}
