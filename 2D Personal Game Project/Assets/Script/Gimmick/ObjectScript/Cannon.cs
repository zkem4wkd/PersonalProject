using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    bool triggerOn = false;
    bool fire = false;
    float deg;
    public GameObject cannon;
    public GameObject target;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            triggerOn = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            triggerOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(triggerOn)
        {
            if(Input.GetKey(KeyCode.DownArrow) && deg < 60)
            {
                deg = deg + Time.deltaTime * 10f;
                float rad = deg * Mathf.Deg2Rad;
                this.transform.rotation = Quaternion.Euler(0, 0, deg);
                target.transform.eulerAngles = new Vector3(0, 0, deg);

            }
            if (Input.GetKey(KeyCode.UpArrow) && deg > 0)
            {
                deg = deg + Time.deltaTime * -10f;
                float rad = deg * Mathf.Deg2Rad;
                this.transform.rotation = Quaternion.Euler(0, 0, deg);
                target.transform.eulerAngles = new Vector3(0, 0, deg);
            }
            if(Input.GetKeyDown(KeyCode.F) && fire == false)
            {
                fire = true;
                transform.GetChild(0).gameObject.SetActive(true);
                GameObject bullet = Instantiate(cannon);
                bullet.transform.position = target.transform.position;
                bullet.GetComponent<Rigidbody2D>().velocity = (target.transform.position - this.transform.position) * 12f;
                this.GetComponent<AudioSource>().Play();
                Destroy(bullet, 10f);
                Invoke("Delay", 1f);
            }
        }
    }
    void Delay()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        fire = false;
    }
}
