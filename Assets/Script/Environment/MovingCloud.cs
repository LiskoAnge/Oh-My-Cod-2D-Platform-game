using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCloud : MonoBehaviour
{


    // public GameObject movCloud;


    public bool fadeCloud = false;

    private bool cDisappeared;

    public float movCloudSpeed;

    Rigidbody2D rgbd;


    public BoxCollider2D colliderCloud;


    public GameObject movingCloud;


    public Transform origPos;


    private MovingCloud mc;





    private void Awake()
    {
        colliderCloud = GetComponent<BoxCollider2D>();
        colliderCloud.enabled = true;

        mc = GetComponent<MovingCloud>();
        mc.enabled = true;
    }


    private void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();


        cDisappeared = false;


        // movCloud.SetActive(false);


    }




    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag.Equals("tPlayer"))
        {
           // movCloud.SetActive(true);
            rgbd.velocity = new Vector2(0f, movCloudSpeed);
            

        }





    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("tStop"))
        {

            cDisappeared = true;


            Destroy(gameObject);

            //Debug.Log("cloud destroyed!");

            // anim.SetTrigger("cloudDisapp");

        }



        if (cDisappeared == true)
        {
           // Transform cloudClone = Instantiate(movingCloud, origPos, Quaternion.identity) as Transform;
          //  bulletClone.name = "enemy";


               Instantiate(movingCloud, origPos.position, Quaternion.identity);
        }
        





    }









}



