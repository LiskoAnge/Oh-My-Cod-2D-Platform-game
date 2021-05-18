using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagFlyX : MonoBehaviour
{


    [SerializeField] float enemySpeed;



    Rigidbody2D rb;
    BoxCollider2D boxColl;
    
    public AudioSource enemyHurtSound;

    Collider2D seagCollider;



    Animator animat;




    void Start()
    {
        animat = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        boxColl = GetComponent<BoxCollider2D>();


        seagCollider = GetComponent<Collider2D>();

    }



    
    void Update()
    {



        


        if (facingRight())
        {
            
            rb.velocity = new Vector2(enemySpeed, 0f);
        } else
        {
            rb.velocity = new Vector2(-enemySpeed, 0f);
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

            // transform.localScale = new Vector2(-(Mathf.Sign(rb.velocity.x)), transform.localScale.y);
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

        if (colli.gameObject.tag.Equals("tSpObj"))
        {
            Invoke("EnemyDefeated", 0);
        }



    }




    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag.Equals("tPlayer"))
        {
            //GetComponent<BoxCollider2D>().enabled = false;


            Invoke("EnemyDefeated", 0);





        }


    }




    public void EnemyDefeated()
    {
        seagCollider.enabled = false;

        enemySpeed = 0f;
        animat.SetTrigger("seagDefeated");
        enemyHurtSound.Play();
        Destroy(gameObject, 0.40f);

    }







}