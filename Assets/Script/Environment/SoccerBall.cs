using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{


    Rigidbody2D rb;
    Animator an;





    private bool bDisappeared = false;
 
    public float speedBall = 2;

   // public CircleCollider2D circColl;

  //  public GameObject sBall;


    //public Transform ballPos;

    private SoccerBall sb;


    private void Awake()
    {


        sb = GetComponent<SoccerBall>();
        sb.enabled = true;
        //circColl = GetComponent<CircleCollider2D>();
       // circColl.enabled = true;
        an = GetComponent<Animator>();
        an.enabled = true;



    }




    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();

        rb.velocity = new Vector2(-speedBall, 0f);
    }




  



    

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag.Equals("tStop"))
        {
            StartCoroutine("KickBall");


        }

        if (coll.gameObject.tag.Equals("tStop2"))
        {
            StartCoroutine("BackKickBall");


        }
    }



    IEnumerator KickBall()
    {
        yield return new WaitForSeconds(0.15f);
        rb.velocity = new Vector2(speedBall, 0f);
        transform.localRotation = Quaternion.Euler(0, 180, 0);
    }

    IEnumerator BackKickBall()
    {
        yield return new WaitForSeconds(0.15f);
        rb.velocity = new Vector2(-speedBall, 0f);
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }





















}
