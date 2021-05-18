using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    float bulletSpeed = 3f;
    Rigidbody2D rgbd;
    //Animator anima;
    public GameObject target;
    Vector2 bulletDirection;


    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("tEnemy");
     
        //anima = GetComponent<Animator>();

        bulletDirection = (target.transform.position - transform.position).normalized * bulletSpeed;
        bulletDirection.x = 0; //i do not want the bullet to move on the x axis
        rgbd.velocity = new Vector2(bulletDirection.x, bulletDirection.y);


    }

    private void OnTriggerEnter2D(Collider2D colli)
    {


        if (colli.gameObject.tag == "tEnemyGround")
        {
      
            Destroy(gameObject);

           // bulletDirection.x = 0;
            //bulletDirection.y = 0;

            //rgbd.velocity = new Vector2(bulletDirection.x, bulletDirection.y);

            //anima.SetTrigger("pDestroyed");

        


        }



        if (colli.gameObject.tag == "tEnemy")
        {
            Destroy(gameObject);
            Debug.Log("projectile destroyed");
        }

    }




}