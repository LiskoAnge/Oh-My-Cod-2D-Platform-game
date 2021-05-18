using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootbPlayer : MonoBehaviour
{


    Animator anim;
   
    void Start()
    {
        anim = GetComponent<Animator>();
    }



    private void OnTriggerEnter2D(Collider2D colli)
    {

        if (colli.gameObject.tag.Equals("tBall"))
        {
            anim.SetBool("isKicking", true);
        } 
        
    }


    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("tBall"))
        {
            anim.SetBool("isKicking", false);
        }
    }



}
