using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{



    [SerializeField] float sharkSpeed;

    Rigidbody2D rb;



    void Start()
    {
   
        rb = GetComponent<Rigidbody2D>();
   

    }

    void Update()
    {


        if (facingRight())
        {

            rb.velocity = new Vector2(sharkSpeed, 0f);
        }
        else
        {
            rb.velocity = new Vector2(-sharkSpeed, 0f);
        }








    }

    private bool facingRight()
    {
        return transform.localScale.x < Mathf.Epsilon;
    }

    private void OnTriggerEnter2D(Collider2D colli)
    {

        if (colli.gameObject.tag == "tStop")
        {

       
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

    }





}
