using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(SpriteRenderer))]
public class EnemySkater : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;

    //Rigidbody2D rgbd;

    public float speedEnemy;
    public float stopDistance;
    public float retreatDistance;          //PUBLIC FLOATS 
    private float shootingRate;
    public float startshootingRate;




    public bool isShooting;        //BOOLEAN


    public GameObject projectile;
    public GameObject enemy;                //GAMEOBJECTS


  //  public AnimationClip anim;
   // float waitTime;

    public Transform skater;          

   // Animator animat;                    //ANIMATOR                  





    void Start()


    {
        skater = GameObject.FindGameObjectWithTag("tPlayer").transform;
        shootingRate = startshootingRate;
       // animat = GetComponent<Animator>();
        //rgbd = GetComponent<Rigidbody2D>();




        //waitTime = anim.length + 2f;
       // InvokeRepeating("PlayAnim", 3f, waitTime);

    }



   

  

    //void PlayAnim()
   // {
        //play your anim here


        //animat.SetTrigger("isShooting");
   // }





    public void Awake()
    {
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();         //THIS IS TO FLIP ENEMY SPRITE WHEN NEEDED
    }



    void Update()
    {

        /////////////ENEMY MOVEMENTS DEPENDING ON PLAYER MOVEMENTS/////////


        if (Vector2.Distance(transform.position, skater.position) > stopDistance)    //if enemy too far from player, enemy moves towards player (skater)
        {
            transform.position = Vector2.MoveTowards(transform.position, skater.position, speedEnemy * Time.deltaTime);
    
        }
        else if (Vector2.Distance(transform.position, skater.position) < stopDistance && Vector2.Distance(transform.position, skater.position) > retreatDistance)
        {           //check if enemy is close enough to target (skater) to stop


            transform.position = this.transform.position;


        } else if (Vector2.Distance(transform.position, skater.position) < retreatDistance)
        {

            transform.position = Vector2.MoveTowards(transform.position, skater.position, -speedEnemy * Time.deltaTime);

        }






        ///////////////////////ENEMY IS SHOOTING//////////////////



        /*
        if (isShooting == true)
        {
            enemy.GetComponent<EnemySkater>().isShooting = true;
            animat.SetBool("isShooting", true);
        } else
        {
            isShooting = false;
        }

        */





        if (shootingRate <= 0)
        {
            //animat.SetTrigger("isShooting");

           // animat.SetTrigger("isShooting");
            Attack();
         //   Instantiate(projectile, transform.position, Quaternion.identity);       //instantiate is to spawn what we want: Instantiate (whatWeSpawn, prosition,rotation); --> in this case no rotation!
            //shootingRate = startshootingRate;  //if i do not do this the enemy will shoot every single frame
 
           


        } else
        {
  
            shootingRate -= Time.deltaTime;
            


        }


        void Attack()
        {
            Debug.Log("Enemy is attacking!");
         
            //StartCoroutine("EnemyShooting");

      
            Instantiate(projectile, transform.position, Quaternion.identity);       //instantiate is to spawn what we want: Instantiate (whatWeSpawn, prosition,rotation); --> in this case no rotation!
            shootingRate = startshootingRate;  //if i do not do this the enemy will shoot every single frame
        }



       

            //animat.SetTrigger("isShooting");
            //StartCoroutine("EnemyShooting");

    


        this.spriteRenderer.flipX = skater.transform.position.x > this.transform.position.x;

    }



    IEnumerator EnemyShooting()
    {


        isShooting = true;
        yield return new WaitForSeconds(0.5f);

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("tPlayer"))
        {

            Destroy(gameObject);
        }
    }

    /*
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "tPlayer")
        {
            animat.SetBool("isDying", true);
            Destroy(gameObject, 1f);
        }

    }

    */



}