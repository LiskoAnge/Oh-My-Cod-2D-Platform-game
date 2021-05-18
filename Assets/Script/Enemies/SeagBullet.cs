using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagBullet : MonoBehaviour
{

    float bulletSpeed = 5f;
    Rigidbody2D rgbd;
    Animator anima;
    public GameObject target;
    Vector2 bulletDirection;







    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("tPtarget");

        anima = GetComponent<Animator>();

        bulletDirection = (target.transform.position - transform.position).normalized * bulletSpeed;
        bulletDirection.x = 0; //i do not want the bullet to move on the y axis
        rgbd.velocity = new Vector2(bulletDirection.x, bulletDirection.y);


    }

    private void OnTriggerEnter2D(Collider2D colli)
    {
        if (colli.gameObject.tag == "tPlayer")
        {
            //Debug.Log("Bullet is destroyed against player!");
    

            Destroy(gameObject);

        }

        if (colli.gameObject.tag == "tGround")
        {
           // Debug.Log("Seagull's bullet is destroyed on the ground!");

            bulletDirection.x = 0;
            bulletDirection.y = 0;

            rgbd.velocity = new Vector2(bulletDirection.x, bulletDirection.y);

            anima.SetTrigger("pDestroyed");

            Destroy(gameObject, 0.6f);
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag.Equals("tPlayer"))
        {

            Debug.Log("Bullet destroyed by player!");

            rgbd.isKinematic = false;

            Destroy(gameObject, 0.6f);


        }


    }


}