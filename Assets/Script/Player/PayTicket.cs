using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayTicket : MonoBehaviour
{


    [SerializeField] float towerSpeed;

    Animator anima;

    Rigidbody2D rb;
    BoxCollider2D boxColl;



    private void Start()
    {
        anima = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();
        boxColl = GetComponent<BoxCollider2D>();

    }


    /*

    
    void Update()
    {




        if (facingRight())
        {

            rb.velocity = new Vector2(0f, towerSpeed);
        }
        else
        {
            rb.velocity = new Vector2(0f, -towerSpeed);
        }


    }

    private bool facingRight()
    {
        return transform.localScale.x < Mathf.Epsilon;
    }


    */


   



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("tPlayer"))
        {
        

            if (OtherScore.otherScoreValue >= 1)
            {

                anima.SetBool("dOpened", true);

                StartCoroutine("WaitAndTowerUp");



                OtherScore.otherScoreValue = 0;



                //rb.velocity = new Vector2(0f, towerSpeed);

                //Debug.Log("collision con l i360 ");

                Debug.Log("collision con l i360 ");



            }

        }




        if (collision.gameObject.tag == "tStop")
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            rb.velocity = new Vector2(0f, -towerSpeed);


        }



        if (collision.gameObject.tag == "tStop2")
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            rb.velocity = new Vector2(0f, towerSpeed);


        }
    }

    IEnumerator WaitAndTowerUp()
    {

        yield return new WaitForSeconds(2f);
        rb.velocity = new Vector2(0f, towerSpeed);




    }



}


