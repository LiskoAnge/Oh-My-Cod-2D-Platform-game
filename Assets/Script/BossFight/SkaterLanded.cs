using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkaterLanded : MonoBehaviour
{
    GameObject Skater;
    public AudioSource wheelSound;



    // Start is called before the first frame update
    void Start()
    {

        Skater = gameObject.transform.parent.gameObject;



    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {


        /*
        if (collision.collider.tag == "tGround")
        {

            Skater.GetComponent<SkaterVsBoss>().isLanded = true;       ADD THIS JUST WHEN (AND IF) YOU ADD JUMP FEATURE TOO
            wheelSound.Play();



        }
        */

        if (collision.collider.tag == "tFall")
        {
            Skater.GetComponent<SkaterVsBoss>().isFalling = true;
        }








    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        /*
        if (collision.collider.tag == "tGround")
        {
            Skater.GetComponent<SkaterVsBoss>().isLanded = false;       ADD THIS JUST WHEN (AND IF) YOU ADD JUMP FEATURE TOO


        }

        */


        if (collision.collider.tag == "tFall")
        {
            Skater.GetComponent<SkaterVsBoss>().isFalling = false;

        }

    }



}

