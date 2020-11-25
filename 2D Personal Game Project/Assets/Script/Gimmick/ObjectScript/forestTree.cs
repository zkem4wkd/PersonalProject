using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class forestTree : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Water"))
        {
            this.GetComponent<PlayableDirector>().Play();
            Destroy(this.gameObject, 5f);
        }
    }
}
