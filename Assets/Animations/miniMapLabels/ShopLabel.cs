using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopLabel : MonoBehaviour
{


    Rigidbody2D rgbd;

    Animator anim;



    void Start()
    {

        rgbd = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

    }


    private void OnTriggerEnter2D(Collider2D colli)
    {
        if (colli.gameObject.tag == "tPlayer")
        {

            anim.SetBool("shopMoves", true);


        }

    }




    private void OnTriggerExit2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "tPlayer")
        {

            anim.SetBool("shopMoves", false);


         
        }

    }



}
