using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkaterEnemy : MonoBehaviour
{


    [SerializeField] float enemySpeed;


    private float shootingRate;
    public float startshootingRate;




    public bool isShooting;        //BOOLEAN


    public GameObject projectile;
    Rigidbody2D rb;
    BoxCollider2D boxColl;

    public AudioSource enemyHurtSound;


    Animator animat;




    void Start()
    {
        animat = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        boxColl = GetComponent<BoxCollider2D>();
        shootingRate = startshootingRate;

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
        return transform.localScale.x > Mathf.Epsilon;
    }





    private void OnTriggerEnter2D(Collider2D colli)
    {



        if (colli.gameObject.tag == "tStop")
        {
            StartCoroutine(Wait());
          //  transform.localScale = new Vector2(-(Mathf.Sign(rb.velocity.x)), transform.localScale.y);
        }



    }




    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "tPlayer")
        {
            GetComponent<BoxCollider2D>().enabled = false;


            enemySpeed = 0;
            enemyHurtSound.Play();
            Invoke("EnemyFalls", 0.1f);
            animat.SetBool("isDying", true);
            Destroy(gameObject, 1f);







        }


    }




    IEnumerator Wait()
    {

        animat.SetTrigger("isShooting");


 

        yield return new WaitForSeconds(2f);

        transform.localScale = new Vector2(-(Mathf.Sign(rb.velocity.x)), transform.localScale.y);

    }





}