
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{

    Animator ani;

    Rigidbody2D rgbd;

    public AudioSource coinSound;

    Collider2D scoreCollider;

    private float coinSpeed = 0.3f;


    private void Start()
    {
  
        ani = GetComponent<Animator>();
        scoreCollider = GetComponent<Collider2D>();
        rgbd = GetComponent<Rigidbody2D>();
    }


    private void OnTriggerEnter2D(Collider2D colli)
    {


        if (colli.gameObject.tag.Equals("tPlayer"))
        {
            scoreCollider.enabled = !scoreCollider.enabled;
           // Debug.Log("Collider.enabled = " + scoreCollider.enabled);
            ScoreScript.scoreValue += 10;
            ani.SetTrigger("goldCoinTaken");
            coinSound.Play();
            rgbd.velocity = new Vector2(0f, coinSpeed);
            Destroy(gameObject, 1);

        }

    }

    
}



