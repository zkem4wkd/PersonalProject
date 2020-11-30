using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed = 3f;
    public bool activeOn = false;
    public GameObject target;
    public Vector2 startPos;
    TotemScript tScript;

    private void Start()
    {
        startPos = this.transform.position;
        tScript = GameObject.FindGameObjectWithTag("Tower").GetComponent<TotemScript>();
    }
    // Update is called once per frame
    void Update()
    {
        if(activeOn == true)
        {
            float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            float yMove = Input.GetAxis("Vertical") * speed * Time.deltaTime; 
            this.transform.Translate(new Vector3(xMove, yMove, 0));  
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Wall"))
        {
            this.transform.position = startPos;
        }
        if(collision.gameObject == target)
        {
            tScript.count++;
            this.transform.position = target.transform.position;
            this.GetComponent<BallScript>().enabled = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball") && activeOn == true)
        {
            this.transform.position = startPos;
        }
    }
    
}
