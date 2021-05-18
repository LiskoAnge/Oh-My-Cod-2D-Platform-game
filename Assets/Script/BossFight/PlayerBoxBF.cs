using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerBoxBF : MonoBehaviour
{




    /*

    public bool boxCrashed = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




        */

    private void Start()
    {

       // platformBreaks = GetComponent<AudioSource>();

    }


    private void OnTriggerEnter2D(Collider2D colli)
    {


        if (colli.gameObject.tag == "tPlof")
        {

            Destroy(gameObject);


        }

        else
        {

            //boxCrashed = false;

        }

    }


}
