using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Umbrella : MonoBehaviour
{

    public AudioSource umbrellaBounce;

    public float umbrellaJump = 5f;



    public Rigidbody2D mRB2D;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag.Equals("tPlayer"))
        {


            umbrellaBounce.Play();


            mRB2D.velocity = Vector2.up * umbrellaJump;

            /*
            GameObject bounce = other.gameObject;
            Rigidbody rb = bounce.GetComponent<Rigidbody>();
            //push player rb in the air
            rb.AddForce(Vector2.up * umbrellaJump);

            */

        }

    }




}
