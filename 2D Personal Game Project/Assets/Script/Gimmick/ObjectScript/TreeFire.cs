using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeFire : MonoBehaviour
{
    public GameObject[] fire;
    public GameObject portal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Fire"))
        {
            for(int i = 0; i < fire.Length; i++)
            {
                fire[i].SetActive(true);
            }
            Destroy(this.gameObject, 5f);
            portal.SetActive(true);
        }
    }
}
