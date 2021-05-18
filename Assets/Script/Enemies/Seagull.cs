using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Seagull : MonoBehaviour
{


    private float shootingRate;
    public float startshootingRate;
    public GameObject projectile;

    Animator animat;                    //ANIMATOR                  
    Rigidbody2D rb;
    BoxCollider2D boxColl;

    void Start()

    {

        shootingRate = startshootingRate;
        animat = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        boxColl = GetComponent<BoxCollider2D>();

    }

    void Update()
    {


        if (shootingRate <= 0)
        {


            animat.SetBool("sgShooting", true);


            Instantiate(projectile, transform.position, Quaternion.identity);       //instantiate is to spawn what we want: Instantiate (whatWeSpawn, prosition,rotation); --> in this case no rotation!


            shootingRate = startshootingRate;  //if i do not do this the enemy will shoot every single frame

        }
        else
        {

            shootingRate -= Time.deltaTime;
            animat.SetBool("sgShooting", false);


        }


    }


}