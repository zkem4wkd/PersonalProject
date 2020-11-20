﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrampolineScript : MonoBehaviour
{
    public Sprite charge;
    Sprite normal;
    Animator ani;
    public float forceX, forceY;
    private void Start()
    {
        normal = this.GetComponent<SpriteRenderer>().sprite;
        ani = GetComponent<Animator>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            this.GetComponent<SpriteRenderer>().sprite = charge;
            if(collision.gameObject.GetComponent<PlayerMove>().jumpCount != collision.gameObject.GetComponent<PlayerMove>().maxJumpCount)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(forceX, forceY),ForceMode2D.Impulse);
                this.GetComponent<AudioSource>().Play();
                ani.SetTrigger("Jump");
            }
        }
    }
}
