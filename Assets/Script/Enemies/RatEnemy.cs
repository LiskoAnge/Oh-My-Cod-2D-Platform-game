using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatEnemy : MonoBehaviour
{
    [SerializeField] float enemySpeed;

    public GameObject rat;

    Rigidbody2D rb;

    Collider2D ratCollider;
 
    public AudioSource enemyHurtSound;


    Animator animat;




    void Start()
    {
        animat = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        ratCollider = GetComponent<Collider2D>();
        ratCollider.enabled = true;



    }




    void Update()
    {






        if (facingRight())
        {

            rb.velocity = new Vector2(enemySpeed, 0f);
        }
        else
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

            Invoke("EnemyDefeated", 0);
         

        }


    }


    public void EnemyDefeated()
    {
        ratCollider.enabled = false;

        enemySpeed = 0f;
        animat.SetTrigger("ratDefeated");
        enemyHurtSound.Play();
        Destroy(gameObject, 0.50f);

    }




}

