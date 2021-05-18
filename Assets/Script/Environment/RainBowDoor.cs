using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainBowDoor : MonoBehaviour
{

    public SkaterMoves skm;
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        
    }



    private void OnTriggerEnter2D(Collider2D col)
    {


        if (col.gameObject.tag.Equals("tPlayer"))
        {




            if (skm.secretRainbow == true)
            {
                anim.SetTrigger("doorRainbowOpens");

            }




        }
        
    }



}


