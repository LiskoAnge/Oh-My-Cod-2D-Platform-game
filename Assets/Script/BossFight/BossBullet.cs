using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{

    float bulletSpeed = 2f;
    Rigidbody2D rgbd;
    //Animator anima;
    public GameObject target;
    Vector2 bulletDirection;

    public AudioSource platformBreaks;




    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("tPlayer");

        //anima = GetComponent<Animator>();
        bulletDirection = (target.transform.position - transform.position).normalized * bulletSpeed;
        bulletDirection.x = 0; //i do not want the bullet to move on the x axis
        rgbd.velocity = new Vector2(bulletDirection.x, bulletDirection.y);


    }

    private void OnTriggerEnter2D(Collider2D colli)
    {
    

        if (colli.gameObject.tag == "tGround")
        {
            StartCoroutine("BulletShot");

        }

    }

    IEnumerator BulletShot()
    {
        platformBreaks.Play();
       // bulletDirection.x = 0;
       // bulletDirection.y = 0;
        rgbd.velocity = new Vector2(bulletDirection.x, bulletDirection.y);
        //anima.SetTrigger("pDestroyed");
        yield return new WaitForSeconds(.6f);  //wait for the sound to play completely before destroying it
        Destroy(gameObject);
    }





}