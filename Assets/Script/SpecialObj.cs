using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialObj : MonoBehaviour
{


    private float shoeSpeed = 10f;
    Rigidbody2D rgbd;

    public GameObject spObjExplodes;
    public Transform explPos;
    //Animator anima;

    Vector2 shoeDirection;


    public SkaterMoves skMoves;


    void Start()
    {

        GameObject gmo = GameObject.FindGameObjectWithTag("tPlayer");
        skMoves = gmo.GetComponent<SkaterMoves>();

        rgbd = GetComponent<Rigidbody2D>();

        Physics2D.IgnoreLayerCollision(18, 20, true);     //ignore collision with the colliders that determine the enemy patrols movement
        Physics2D.IgnoreLayerCollision(18, 9, true);      //ignore collision with player, otherwise if the player moves and shoots in the same time, its collider will destroy bullet or its particle system before it can land somewhere else
        Physics2D.IgnoreLayerCollision(18, 15, true);
        // Debug.Log("bullet instantiated");

        // rgbd.GetComponent<Rigidbody2D>().AddForce(new Vector2(-0.1f, 0.5f), ForceMode2D.Impulse);


        // rgbd.AddForce(gameObject.transform.forward * shoeSpeed);


        if (skMoves.facingRight == true)
        {
            rgbd.GetComponent<Rigidbody2D>().AddForce(new Vector2(4f, 2f), ForceMode2D.Impulse);

        }
        else if (skMoves.facingRight == false)
        {

            rgbd.GetComponent<Rigidbody2D>().AddForce(new Vector2(-4f, 2f), ForceMode2D.Impulse);

        }

    }


    private void OnTriggerEnter2D(Collider2D col)
    {


        StartCoroutine("ShoeExplodes");




  



    }


    



    IEnumerator ShoeExplodes()
    {




        Instantiate(spObjExplodes, explPos.position, Quaternion.identity);

        yield return new WaitForSeconds(0.2f);


        Destroy(gameObject);

   
      

    }
















}









