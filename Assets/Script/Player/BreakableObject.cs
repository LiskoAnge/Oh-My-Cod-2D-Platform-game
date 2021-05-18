using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{

    Animator animat;

    private BoxCollider2D boxColl;
    public Transform rewardPos;
    public GameObject reward;

    public AudioSource destroyObject;

    private void Start()
    {

        boxColl = GetComponent<BoxCollider2D>();
        boxColl.enabled = true;
        animat = GetComponent<Animator>();

    }


    /*

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if ((Input.GetButton("Vertical")) && coll.gameObject.tag.Equals("tPlayer"))
        {


            destroyObject.Play();
            animat.SetTrigger("breakingObject");
            Destroy(gameObject, 0.40f);




        }

    }
    
   




    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (Input.GetKey(KeyCode.UpArrow) && coll.gameObject.tag.Equals("tPlayer"))
        {


            Invoke("BoxDestr", 0);




        }

    }

     */





    private void OnCollisionEnter2D(Collision2D coll)
    {


        if (Input.GetKey(KeyCode.UpArrow))
        {



            if (coll.gameObject.tag.Equals("tPlayer"))
            {




                StartCoroutine("BoxDestr");

            }





        }



  


    }


    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag.Equals("tSpObj"))
        {

            StartCoroutine("BoxDestr");

        }

    }



    public IEnumerator BoxDestr()
    {


        boxColl.enabled = false;
        destroyObject.Play();
        animat.SetTrigger("breakingObject");


        yield return new WaitForSeconds(0.2f);



        Instantiate(reward, rewardPos.position, rewardPos.rotation);
        Destroy(gameObject, 0.40f);

    }


  





}
