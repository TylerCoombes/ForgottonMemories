using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public Rigidbody2D rb;

    void start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            rb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
            
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }

        if (col.gameObject.CompareTag ("Ground"))
        {
            Destroy(this.gameObject);
        }

        if (col.gameObject.CompareTag ("Spike"))
        {
            Destroy(this.gameObject);
        }
                    
    }
}

