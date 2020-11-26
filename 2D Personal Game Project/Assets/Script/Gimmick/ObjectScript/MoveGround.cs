using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    GameObject player;
    bool onGround = false;
    Vector3 distance;

    void Update()
    {
        if(player != null)
        {
            if(onGround == true && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {
                player.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + 0.94f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            onGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            player = null;
            onGround = false;
        }
    }
}
