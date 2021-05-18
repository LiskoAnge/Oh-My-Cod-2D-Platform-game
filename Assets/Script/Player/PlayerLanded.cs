using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLanded : MonoBehaviour
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

        if (collision.collider.tag == "tGround")
        {
            
            Skater.GetComponent<SkaterMoves>().isLanded = true;
            wheelSound.Play();



        }


        if (collision.collider.tag == "tFall")
        {
            Skater.GetComponent<SkaterMoves>().isFalling = true;
        }

       






    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.collider.tag == "tGround")
        {
            Skater.GetComponent<SkaterMoves>().isLanded = false;
          

        }


        if (collision.collider.tag == "tFall")
        {
            Skater.GetComponent<SkaterMoves>().isFalling = false;

        }

    }



}
