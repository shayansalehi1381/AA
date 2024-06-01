using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Debug.Log("hi");
            isPinned = true;
            rb.velocity = Vector2.zero; // Ensure the pin stops moving
            rb.isKinematic = true; // Make Rigidbody kinematic to stop all physics interactions
            transform.SetParent(collision.transform);
        }
    }



}
