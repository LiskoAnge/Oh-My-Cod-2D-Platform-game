using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{



    float dirX;

    public float speedPlatform = 1;

    bool movingRight = true;


    private void Update()
    {

        /*
        if (transform.position.x > 1f)
        {
            movingRight = false;
        }
        if (transform.position.x < -1f)
        {
            movingRight = true;
        }

        */



        if (movingRight)
        {
            transform.position = new Vector2(transform.position.x + speedPlatform * Time.deltaTime, transform.position.y);
        } else
        {
            transform.position = new Vector2(transform.position.x - speedPlatform * Time.deltaTime, transform.position.y);
        }





    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "tStop")
        {

            movingRight = true;


        }



        if (collision.gameObject.tag == "tStop2")
        {

            movingRight = false;


        }
    }








}


