using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SkaterGoes : MonoBehaviour
{

    public Vector2 move;
    public float skaterSpeed = 1f;
    public Rigidbody2D rb;
    private Animator anima;

    //private Animator ani;

    public AudioSource plofHat;
    //public Animator fading;


    void Start()
    {


        anima = GetComponent<Animator>();
       // ani = GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();



    }


    void Update()
    {



        rb.velocity = new Vector2(skaterSpeed, 0f);

        ///rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);

        


    }


    private void OnTriggerEnter2D(Collider2D colli)
    {

        if (colli.gameObject.tag.Equals("tEnemy"))
        {

            Debug.Log("skater stops");


            skaterSpeed = 0.5f;

            plofHat.Play();

            anima.SetBool("hatDirty", true);


            //ani.SetTrigger("darkScreen");

            // WaitAndStartGame();




        }

        /*

        if (colli.gameObject.tag.Equals("tGame"))
        {

            Debug.Log("detected collision");
            SceneManager.LoadScene(1);
            // WaitAndStartGame();




        }

    
        */



    }



    /*



    IEnumerator WaitAndStartGame()
    {
        //fading.SetTrigger("Start");

        skaterSpeed = 0f;
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(1);
    }

    */


}




