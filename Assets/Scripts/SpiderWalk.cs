using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWalk : MonoBehaviour
{
    private float speed;
    private float direction;
    Rigidbody2D rb;
        void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Let")
        {
            speed = speed + 0.5f;
            direction = -direction;
        }
        
    }
    void Start()
    {
        direction = 1f;
        speed = 5f;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(speed * direction, 0);
    }

   
}
