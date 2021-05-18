using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagStory : MonoBehaviour
{

    public GameObject bullet;
    private Animator anim;

    private void Start()
    {

        anim = GetComponent<Animator>();

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "tPlayer")
        {


            anim.SetBool("sgShooting", true);
            Instantiate(bullet, transform.position, Quaternion.identity);

     

        }
      
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("sgShooting", false);
    }
}


