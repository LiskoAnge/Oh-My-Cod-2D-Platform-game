using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagFlyY : MonoBehaviour
{

    [SerializeField] float enemySpeed;



    Rigidbody2D rb;



    Collider2D seagCollider;


    public AudioSource enemyHurtSound;


    Animator anim;




    void Start()
    {
   
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();


        seagCollider = GetComponent<Collider2D>();



    }




    void Update()
    {




        if (facingRight())
        {

            rb.velocity = new Vector2(0f, enemySpeed);
        }
        else
        {
            rb.velocity = new Vector2(0f, -enemySpeed);
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


            Invoke("EnemyDefeated", 0);

            

        }


    }




    public void EnemyDefeated()
    {
        seagCollider.enabled = false;

        enemySpeed = 0f;
        anim.SetTrigger("seagDefeated");
        enemyHurtSound.Play();
        Destroy(gameObject, 0.40f);

    }






}