using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingItem : MonoBehaviour
{

    Rigidbody2D rigbd;


    Collider2D plankColl;



    void Start()
    {
        rigbd = GetComponent<Rigidbody2D>();
        plankColl = GetComponent<Collider2D>();
        plankColl.enabled = true;
       

    }



    private void OnCollisionEnter2D(Collision2D coll)
    {
        Invoke("ItemFalls", 0.2f);




    }


    void ItemFalls ()
    {
        rigbd.isKinematic = false;
        plankColl.enabled = false;
        Destroy(gameObject, 2f);
    }



}




