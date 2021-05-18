using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ShootingEnemy : MonoBehaviour
{

    private float shootingRate;
    public float startshootingRate;
    public GameObject projectile;
    public AudioSource enemyHurtSound;
    Animator animat;                    //ANIMATOR                  
    Rigidbody2D rb;
    BoxCollider2D boxColl;

    void Start()
    {

        shootingRate = startshootingRate;
        animat = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        boxColl = GetComponent<BoxCollider2D>();
    }

    void Update()
    {


        if (shootingRate <= 0)
        {
            //animat.SetTrigger("isShooting");
            animat.SetBool("isShooting", true);
            Instantiate(projectile, transform.position, Quaternion.identity);       //instantiate is to spawn what we want: Instantiate (whatWeSpawn, prosition,rotation); --> in this case no rotation!

            shootingRate = startshootingRate;  //if i do not do this the enemy will shoot every single frame
        }
        else
        {

            shootingRate -= Time.deltaTime;
            animat.SetBool("isShooting", false);


        }

      
        







    }


    /*

    private void OnTriggerEnter2D(Collider2D colli)
    {



        if (colli.gameObject.tag == "tStop")
        {

            transform.localScale = new Vector2(-(Mathf.Sign(rb.velocity.x)), transform.localScale.y);
        }



    }


    */

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "tPlayer")
        {


            animat.SetBool("isShooting", false);
            GetComponent<BoxCollider2D>().enabled = false;


            enemyHurtSound.Play();
            ScoreScript.scoreValue += 400;
            Invoke("EnemyFalls", 0.1f);

       
            animat.SetBool("isDying", true);
            Destroy(gameObject, 1f);







        }


    }


    void EnemyFalls()
    {

        rb.isKinematic = false;
    }











}