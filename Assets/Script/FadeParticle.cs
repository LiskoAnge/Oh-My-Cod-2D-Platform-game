using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeParticle : MonoBehaviour
{



    Animator ani;

    public MovingCloud movingC;



    void Start()
    {


        ani = GetComponent<Animator>();
        movingC = GetComponent<MovingCloud>();

    }



    private void Update()
    {
        if (movingC.fadeCloud == true)
        {
            ani.SetTrigger("fadeParticle");

        }



    }






}
