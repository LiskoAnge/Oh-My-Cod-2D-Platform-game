using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class AddOtherScore : MonoBehaviour
{


    Animator ani;
    Rigidbody2D rgbd;
    private float purpleCoinSpeed = 0.3f;
    public AudioSource purpleCoinSound;
    Collider2D otherScoreCollider;


    private void Start()
    {
        ani = GetComponent<Animator>();
        otherScoreCollider = GetComponent<Collider2D>();
        rgbd = GetComponent<Rigidbody2D>();
    }


    private void OnTriggerEnter2D(Collider2D colli)
    {

        if (colli.gameObject.tag.Equals("tPlayer"))
        {
            //Debug.Log("Special coin picked up");


            otherScoreCollider.enabled = false;
            OtherScore.otherScoreValue += 1;
            purpleCoinSound.Play();
            ani.SetTrigger("purpleCoinTaken");
            rgbd.velocity = new Vector2(0f, purpleCoinSpeed);
            Destroy(gameObject, 1f);
        }

    }




}
