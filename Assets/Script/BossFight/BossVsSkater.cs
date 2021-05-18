using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossVsSkater : MonoBehaviour
{
    public bool collBox1 = false;
    public bool collBox2 = false;
    public bool collBox3 = false;
    public bool collBox4 = false;
    public bool collBox5 = false;


    public GameObject box1, box2, box3, box4, box5;
    public Transform Box1Pos, Box2Pos, Box3Pos, Box4Pos, Box5Pos;

    public bool isFalling = false;
    public GameObject spawnBox;



    void Start()
    {



    }

    void Update()
    {


        if (collBox1 == true && box1 == null)
        {

            Instantiate(spawnBox, Box1Pos.position, Quaternion.identity);

        }
        if (collBox2 == true && box2 == null)
        {

            Instantiate(spawnBox, Box2Pos.position, Quaternion.identity);

        }
   
        if (collBox3 == true && box3 == null)
        {
            Instantiate(spawnBox, Box3Pos.position, Quaternion.identity);
        }

        if (collBox4 == true && box4 == null)
        {
            Instantiate(spawnBox, Box4Pos.position, Quaternion.identity);
        }

   
        if (collBox5 == true && box5 == null)
        {
            Instantiate(spawnBox, Box5Pos.position, Quaternion.identity);

        }
    }





    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "tBox1Pos")
        {
            collBox1 = true;

        }
        else
        {
            collBox1 = false;

        }
        if (coll.gameObject.tag == "tBox2Pos")
        {
            collBox2 = true;

        }
        else
        {
            collBox2 = false;

        }
        if (coll.gameObject.tag == "tBox3Pos")
        {
            collBox3 = true;

        }
        else
        {
            collBox3 = false;

        }
        if (coll.gameObject.tag == "tBox4Pos")
        {
            collBox4 = true;

        }
        else
        {
            collBox4 = false;

        }
        if (coll.gameObject.tag == "tBox5Pos")
        {
            collBox5 = true;

        }
        else
        {
            collBox5 = false;

        }
    }



}

