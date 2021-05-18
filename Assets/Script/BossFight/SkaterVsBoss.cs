using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkaterVsBoss : MonoBehaviour
{
    public bool collBox1 = false;
    public bool collBox2 = false;
    public bool collBox3 = false;
    public bool collBox4 = false;
    public bool collBox5 = false;
    public bool collBox6 = false;
    public bool collBox7 = false;


    public Transform shootPos;

    public GameObject box1, box2, box3, box4, box5, box6, box7;
    public Transform Box1Pos, Box2Pos, Box3Pos, Box4Pos, Box5Pos, Box6Pos, Box7Pos;

    public bool isFalling = false;
    public bool isShooting;

    private float skater2Speed = 1f;
    public Vector2 movement;
    private bool skFacingRight;
    public Rigidbody2D mRB2D2;

    public GameObject spawnBox;

    public GameObject spawnBullet;

    Animator anima;
    private int clickCount = 0;

    public float fireRate = 0.5F;
    private float nextFire = 0.0F;


    public AudioSource hammer1;
    public AudioSource hammer2;
    public AudioSource hammer3;

    public AudioSource gunShot;
    public AudioSource splash;



    // public PlayerBoxBF boxPlayer;     GETTING BOOLEAN FROM ANOTHER CLASS
    //public Transform box1Pos, box2Pos, box3Pos, box4Pos, box5Pos, box6Pos, box7Pos;



    void Start()
    {

        anima = GetComponent<Animator>();
    }

    void Update()
    {



        float tHorizontal = Input.GetAxis("Horizontal"); //Get left/right

        mRB2D2.velocity = new Vector2(tHorizontal * skater2Speed, mRB2D2.velocity.y);


        if (Input.GetAxis("Horizontal") > 0.5f)
        {

            // anima.SetBool("isMoving", true);

     
            movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * skater2Speed * Time.deltaTime, 0f, 0f));
            skFacingRight = true;
            transform.localRotation = Quaternion.Euler(0, 0, 0);



        }
        else if (Input.GetAxis("Horizontal") < -0.5f)
        {
            //anima.SetBool("isWalking", true);
 
            movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * -skater2Speed * Time.deltaTime, 0f, 0f));
            skFacingRight = false;
            transform.localRotation = Quaternion.Euler(0, 180, 0); //if player is not facing right, rotate image 180 degrees




        }
        else
        {

            //anima.SetBool("isMoving", false);
        }



        if (Input.GetButtonDown("Vertical") && Time.time > nextFire)         //input to t   destroy objects (eg trapdoor)
        {
            //isShooting = true;


            nextFire = Time.time + fireRate;
            gunShot.Play();
            GameObject clone = Instantiate(spawnBullet, shootPos.position, transform.rotation) as GameObject;


           

            // Instantiate(spawnBullet, transform.position, Quaternion.identity);



            //Debug.Log("Player is kicking");
            //anima.SetBool("isPushing", true);
            // kickSound.Play();






        }
        else if (Input.GetButtonUp("Vertical"))
        {
          //  isShooting = false;
           // anima.SetBool("isPushing", false);

        }





        /*
        if (Input.GetButtonDown("Crouch"))
        {
            Debug.Log("Player is fixed the box!");

            Instantiate(spawnBox, box1Pos.position, Quaternion.identity);


       ///////justincase///////
        
        if (box1 == null)
        {

            if (fixBox1 == true && Input.GetButtonDown("Crouch"))       //check for user input and if box is replaceable (I can not replace a box if it hasn't been destroyed by the enemy yet!!)
            {
                Debug.Log("Player fixed the 1 box!");

                Instantiate(spawnBox, Box1Pos.position, Quaternion.identity);
                //anima.SetBool("isFixing", true);

            }
        }

        /////justincase///////

            //anima.SetBool("isFixing", true);                                          
        }

        */





        if (collBox1 == true && box1 == null)
        {

            if (Input.GetButtonDown("Crouch"))       //check for user input and if box is replaceable (I can not replace a box if it hasn't been destroyed by the enemy yet!!)
            {
                // Debug.Log("Player fixed the 3 box!");

                
                clickCount++;

                if (clickCount == 1)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);

                }
                if (clickCount == 2)
                {
                    hammer1.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);


                }
                if (clickCount == 3)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);


                }
                if (clickCount == 4)
                {
                    hammer2.Play(); 
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);

                }
                if (clickCount == 5)
                {
                    anima.SetBool("hammerUp", true);
                    anima.SetBool("hammerDown", false);

                }
                if (clickCount == 6)
                {

                    hammer3.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetTrigger("endHammer");
                    Instantiate(spawnBox, Box1Pos.position, Quaternion.identity);
                    clickCount = 0;

                }



            }
    
        }

        else if (box1 != null)     
        {
           

        }


        if (collBox2 == true && box2 == null)
        {

            if (Input.GetButtonDown("Crouch"))       //check for user input and if box is replaceable (I can not replace a box if it hasn't been destroyed by the enemy yet!!)
            {
                // Debug.Log("Player fixed the 3 box!");
             
                clickCount++;

                if (clickCount == 1)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);

                }
                if (clickCount == 2)
                {
                    hammer1.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);


                }
                if (clickCount == 3)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);


                }
                if (clickCount == 4)
                {
                    hammer2.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);

                }
                if (clickCount == 5)
                {
                    anima.SetBool("hammerUp", true);
                    anima.SetBool("hammerDown", false);

                }
                if (clickCount == 6)
                {
                    hammer3.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetTrigger("endHammer");
                    Instantiate(spawnBox, Box2Pos.position, Quaternion.identity);
                    clickCount = 0;

                }



            }
        
        }
        else if (box2 != null)
        {
            
        }



        if (collBox3 == true && box3 == null)
        {

            if (Input.GetButtonDown("Crouch"))       //check for user input and if box is replaceable (I can not replace a box if it hasn't been destroyed by the enemy yet!!)
            {
                // Debug.Log("Player fixed the 3 box!");
            
                clickCount++;

                if (clickCount == 1)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);

                }
                if (clickCount == 2)
                {
                    hammer1.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);
             

                }
                if (clickCount == 3)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);
        

                }
                if (clickCount == 4)
                {
                    hammer2.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);

                }
                if (clickCount == 5)
                {
                    anima.SetBool("hammerUp", true);
                    anima.SetBool("hammerDown", false);

                }
                if (clickCount == 6)
                {
                    hammer3.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetTrigger("endHammer");
                    Instantiate(spawnBox, Box3Pos.position, Quaternion.identity);
                    clickCount = 0;

                }
           


            }
      
            // anima.SetBool("hammerUp", false);
            //anima.SetBool("hammerDown", false);
        }


        else if (box3 != null && Input.GetButtonDown("Crouch"))
        {
      
        }



        if (collBox4 == true && box4 == null)
        {
            if (Input.GetButtonDown("Crouch"))       //check for user input and if box is replaceable (I can not replace a box if it hasn't been destroyed by the enemy yet!!)
            {
                // Debug.Log("Player fixed the 3 box!");
    
                clickCount++;

                if (clickCount == 1)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);

                }
                if (clickCount == 2)
                {
                    hammer1.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);


                }
                if (clickCount == 3)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);


                }
                if (clickCount == 4)
                {
                    hammer2.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);

                }
                if (clickCount == 5)
                {
                    anima.SetBool("hammerUp", true);
                    anima.SetBool("hammerDown", false);

                }
                if (clickCount == 6)
                {
                    hammer3.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetTrigger("endHammer");
                    Instantiate(spawnBox, Box4Pos.position, Quaternion.identity);
                    clickCount = 0;

                }



            }



        }

        else if (box4 != null)
        {

   
   

        }


        if (collBox5 == true && box5 == null)
        {
            if (Input.GetButtonDown("Crouch"))       //check for user input and if box is replaceable (I can not replace a box if it hasn't been destroyed by the enemy yet!!)
            {
                // Debug.Log("Player fixed the 3 box!");
        
                clickCount++;

                if (clickCount == 1)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);

                }
                if (clickCount == 2)
                {
                    hammer1.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);


                }
                if (clickCount == 3)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);


                }
                if (clickCount == 4)
                {
                    hammer2.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);

                }
                if (clickCount == 5)
                {
                    anima.SetBool("hammerUp", true);
                    anima.SetBool("hammerDown", false);

                }
                if (clickCount == 6)
                {
                    hammer3.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetTrigger("endHammer");
                    Instantiate(spawnBox, Box5Pos.position, Quaternion.identity);
                    clickCount = 0;

                }



            }
   

        }


        else if (box5 != null)
        {

    
        }


        if (collBox6 == true && box6 == null)
        {
            if (Input.GetButtonDown("Crouch"))       //check for user input and if box is replaceable (I can not replace a box if it hasn't been destroyed by the enemy yet!!)
            {
                // Debug.Log("Player fixed the 3 box!");

                clickCount++;

                if (clickCount == 1)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);

                }
                if (clickCount == 2)
                {
                    hammer1.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);


                }
                if (clickCount == 3)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);


                }
                if (clickCount == 4)
                {
                    hammer2.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);

                }
                if (clickCount == 5)
                {
                    anima.SetBool("hammerUp", true);
                    anima.SetBool("hammerDown", false);

                }
                if (clickCount == 6)
                {
                    hammer3.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetTrigger("endHammer");
                    Instantiate(spawnBox, Box6Pos.position, Quaternion.identity);
                    clickCount = 0;

                }



            }


        }


        else if (box6 != null)
        {


        }


        if (collBox7 == true && box7 == null)
        {
            if (Input.GetButtonDown("Crouch"))       //check for user input and if box is replaceable (I can not replace a box if it hasn't been destroyed by the enemy yet!!)
            {
                // Debug.Log("Player fixed the 3 box!");

                clickCount++;

                if (clickCount == 1)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);

                }
                if (clickCount == 2)
                {
                    hammer1.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);


                }
                if (clickCount == 3)
                {
                    anima.SetBool("hammerDown", false);
                    anima.SetBool("hammerUp", true);


                }
                if (clickCount == 4)
                {
                    hammer2.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetBool("hammerDown", true);

                }
                if (clickCount == 5)
                {
                    anima.SetBool("hammerUp", true);
                    anima.SetBool("hammerDown", false);

                }
                if (clickCount == 6)
                {
                    hammer3.Play();
                    anima.SetBool("hammerUp", false);
                    anima.SetTrigger("endHammer");
                    Instantiate(spawnBox, Box7Pos.position, Quaternion.identity);
                    clickCount = 0;

                }



            }


        }


        else if (box7 != null)
        {


        }







        /*
        if (isFalling == true)
        {


            //restartButton.enabled = true;
            //restartButton.gameObject.SetActive(true);
            //gameOverText.enabled = true;

           // Debug.Log("Player is falling! GAME OVER");                               //GAME OVER ///////////////////////////
            //anima.SetBool("isDead", true); 

            // playGameOverSound = false;
        }

        */


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
        if (coll.gameObject.tag == "tBox6Pos")
        {
            collBox6 = true;

        }
        else
        {
            collBox6 = false;

        }
        if (coll.gameObject.tag == "tBox7Pos")
        {
            collBox7 = true;

        }
        else
        {
            collBox7 = false;

        }


        if (coll.gameObject.tag.Equals("tFall"))
        {

            StartCoroutine("gameOver");
    
            //Debug.Log("GAME OVER");         
            // anima.SetBool("isDead", true);

            // SceneManager.LoadScene(10);

        }





    }


    IEnumerator gameOver()
    {

        LiskoLifeScript.liskoValue -= 1;
        splash.Play();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

 

    private void OnTriggerExit2D(Collider2D other)                    //if the player decides (for whatever reason) to interrupt the repair of a platorm, the repairing animation will be stopped and the counter reset
    {



        if (other.gameObject.tag == "tBox1Pos")
        {
            collBox1 = false;
            clickCount = 0;
            anima.SetBool("hammerUp", false);
            anima.SetBool("hammerDown", false);
            anima.SetTrigger("endHammer");

        }
    
        if (other.gameObject.tag == "tBox2Pos")
        {
            collBox2 = false;
            clickCount = 0;
            anima.SetBool("hammerUp", false);
            anima.SetBool("hammerDown", false);
            anima.SetTrigger("endHammer");

        }
   
        if (other.gameObject.tag == "tBox3Pos")
        {
            collBox3 = false;
            clickCount = 0;
            anima.SetBool("hammerUp", false);
            anima.SetBool("hammerDown", false);
            anima.SetTrigger("endHammer");

        }
  
        if (other.gameObject.tag == "tBox4Pos")
        {
            collBox4 = false;
            clickCount = 0;
            anima.SetBool("hammerUp", false);
            anima.SetBool("hammerDown", false);
            anima.SetTrigger("endHammer");

        }
 
        if (other.gameObject.tag == "tBox5Pos")
        {
            collBox5 = false;
            clickCount = 0;
            anima.SetBool("hammerUp", false);
            anima.SetBool("hammerDown", false);
            anima.SetTrigger("endHammer");
        }
     
        if (other.gameObject.tag == "tBox6Pos")
        {
            collBox6 = false;
            clickCount = 0;
            anima.SetBool("hammerUp", false);
            anima.SetBool("hammerDown", false);
            anima.SetTrigger("endHammer");

        }

        if (other.gameObject.tag == "tBox7Pos")
        {
            collBox7 = false;
            clickCount = 0;
            anima.SetBool("hammerUp", false);
            anima.SetBool("hammerDown", false);
            anima.SetTrigger("endHammer");

        }
    


    }







}

