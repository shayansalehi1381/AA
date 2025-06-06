using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public float speed = 20f;
    public Rigidbody2D rb;

     void Update()
    {       if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }   
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rotator")
        {
           
            isPinned = true;
            Score.score++;
            
            transform.SetParent(collision.transform);
        }

        else if (collision.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }



}
