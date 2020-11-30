using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TotemScript : MonoBehaviour
{
    public Sprite[] light;
    public SpriteRenderer totemRight;
    public GameObject[] balls;
    public int count;
    int pNumber;
    bool action = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            totemRight.gameObject.SetActive(true);
            pNumber = collision.gameObject.GetComponent<PlayerMove>().playerNumber;
            totemRight.sprite = light[pNumber-1];
            balls[pNumber-1].GetComponent<BallScript>().activeOn = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            balls[pNumber-1].GetComponent<BallScript>().activeOn = false;
            totemRight.gameObject.SetActive(false);
        }
    }

    public void ResetBtn()
    {
        for(int i = 0; i < balls.Length; i++)
        {
            balls[i].transform.position = balls[i].GetComponent<BallScript>().startPos;
            balls[i].GetComponent<BallScript>().enabled = true;
            count = 0;
        }
    }
    private void Update()
    {
        if(count == 4 && action == false)
        {
            action = true;
            this.GetComponent<PlayableDirector>().Play();
        }
    }
}
