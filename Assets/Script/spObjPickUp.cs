using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spObjPickUp : MonoBehaviour
{
    Animator anim;

    Rigidbody2D rgbd;

    public AudioSource spObjSound;

    Collider2D scoreCollider;

    private float coinSpeed = 0.3f;





    private void Start()
    {
        anim = GetComponent<Animator>();
        scoreCollider = GetComponent<Collider2D>();
        rgbd = GetComponent<Rigidbody2D>();
    }




    private void OnTriggerEnter2D(Collider2D colli)
    {

        if (colli.gameObject.tag.Equals("tPlayer"))
        {

            //Debug.Log("Coin picked up");
            spObjSound.Play();


            scoreCollider.enabled = false;
            anim.SetTrigger("spObjPicked");
            rgbd.velocity = new Vector2(0f, coinSpeed);
            Destroy(gameObject, 0.5f);
        }

    }


    private void OnTriggerExit2D(Collider2D collision)
    {


        scoreCollider.enabled = true;


    }

}
