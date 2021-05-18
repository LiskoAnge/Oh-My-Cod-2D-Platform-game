using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRPCage : MonoBehaviour
{
    Animator anim;




    void Start()
    {

        anim = GetComponent<Animator>();
 
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("tPlayer"))
        {


            if (OtherScore.otherScoreValue >= 1)
            {


       
                OtherScore.otherScoreValue = 0;
                anim.SetTrigger("cageRPOpens");





            }

        }
    }


}
