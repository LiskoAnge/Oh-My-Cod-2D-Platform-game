using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformY : MonoBehaviour
{


    float dirY;

    public float speedPlatform = 1;

    bool movingUp = true;


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



        if (movingUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speedPlatform * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speedPlatform * Time.deltaTime);
        }





    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "tStop")
        {

            movingUp = true;


        }



        if (collision.gameObject.tag == "tStop2")
        {

            movingUp = false;


        }
    }








}



