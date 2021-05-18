using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    [SerializeField] float platformSpeed;

    Rigidbody2D rb;

    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag.Equals("tPlayer"))
        {

            rb.velocity = new Vector2(0f, -platformSpeed);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      


        if (collision.gameObject.tag == "tStop")
        {

            platformSpeed = 0;

            rb.velocity = new Vector2(0f, platformSpeed);


        }
    }


}

