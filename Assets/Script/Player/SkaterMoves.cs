using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SkaterMoves : MonoBehaviour
{


    private bool underCeiling = false;
    public bool isCrouching = false;

    // public Text gameOverText;
    // public Button restartButton;

    public GameObject spawnShoe;
                     //GAMEOBJECTS

    private bool canShoot = false;


    public bool shootingShoes = false;
    public bool jumpHigherAnge = false;
    public bool secretRainbow = false;

    public bool isLanded = false;
    public bool isKicking;
    private bool isJumping;
    public bool isFalling = false;
    public bool isHurting = false;                                 //BOOLEANS
    public bool isDead;
    public bool facingRight;

    public bool faster = false;


    //private bool speedBoost;
    //bool playGameOverSound = false;

    private float timeBtwKick;
    private float btwNinjaShoot;
    public float startTimeBtwKick = 1f;
  //  public float stBtwNinja = 1f;

    private float jumpTimeCount;
    public float jumpTime;                             
    public float kickRange;
    private float jumpForce = 3.5f;                                //FLOATS                   -set public otherwise can not change value in the inspecotr
    public float gameOverDelay = 1f;
    public float skaterSpeed = 0.9f;
    private float boostTime;

    public Transform kickPos;

    public AnimatorOverrideController darkSkaterAnim;              //NINJA LISKO SKIN
    public AnimatorOverrideController angeLiskoAnim;              //ANGE LISKO SKIN
    public AnimatorOverrideController rainbowLiskoAnim;              //ANGE LISKO SKIN

    int isLiskoNinja;
    int isLiskoAnge;
    int isLiskoRainbow;

    public Rigidbody2D mRB2D;

    Animator anima;

    public Vector2 movement;

    Renderer render;

    Color invisible;    //it is not actually properly invisible, it is a fast change between opaque and transparent...

    // Save saveGameData;

    public LayerMask kickableGroup;
   // public LayerMask enemiesToKick;

    public AudioSource notEnoughCoins;
    public AudioSource itemSold;
    public AudioSource skateSound;
    public AudioSource speedBoostSound;        //SOUNDS
    public AudioSource wheelExplodes;
    public AudioSource kickSound;
    public AudioSource plof;
    public AudioSource hitSound;

    //public AudioSource playerHit;
    //public AudioSource bckMusic;
    //public AudioSource gameOverMusic;
  //  public BoxCollider2D shorterCollider;


    private void Awake()
    {

        isLiskoNinja = PlayerPrefs.GetInt("ninjaLis");

        isLiskoAnge = PlayerPrefs.GetInt("angeLis");

        isLiskoRainbow = PlayerPrefs.GetInt("rainbowLis");


        if (isLiskoNinja == 1)
        {
            shootingShoes = true;
            GetComponent<Animator>().runtimeAnimatorController = darkSkaterAnim as RuntimeAnimatorController;
        }

        if (isLiskoAnge == 2)
        {
            jumpHigherAnge = true;
            GetComponent<Animator>().runtimeAnimatorController = angeLiskoAnim as RuntimeAnimatorController;
        }

        if (isLiskoRainbow == 3)
        {
            secretRainbow = true;
            GetComponent<Animator>().runtimeAnimatorController = rainbowLiskoAnim as RuntimeAnimatorController;
        }
    

    }




   
    void Start()
    {

        anima = GetComponent<Animator>();
        mRB2D = gameObject.GetComponent<Rigidbody2D>();
        render = GetComponent<Renderer>();
        Physics2D.IgnoreLayerCollision(9, 10, false);         //otherwise when reloading scene (e.g. checkpoint) the collision does not work anymore!
        jumpForce = 3.5f;
        boostTime = 0;
        invisible = render.material.color;
 

        //gameOverText.enabled = false;
        //restartButton.enabled = false;
        //restartButton.gameObject.SetActive(false);
       // transform.position = new Vector3(-0.855f, 0f, 0.0f);   //skater initial position x y z 
      // shorterCollider = GetComponent<BoxCollider2D>();
        // speedBoost = false;
        // noCoinsText.SetActive(false);
    }



    private void FixedUpdate()
    {
        //float tVertical = Input.GetAxis("Vertical");    //Get up/down
       // mRB2D.velocity = new Vector2(tHorizontal * skaterSpeed, mRB2D.velocity.y);
    }



    void Update()
    {




        Physics2D.IgnoreLayerCollision(9, 20);     // 9 = PLAYER'S LAYER. 20 = IGNORE COLLISION AT LAYER N.20.THIS LAYER IS NEEDED TO STOP CLOUD PLATFORM OR ENEMY PATROL


        if (Input.GetButtonDown("Jump") && isLanded == true)     //&& !isDead
        {
            //Debug.Log("Player is jumping!");
            isJumping = true;
            jumpTimeCount = jumpTime;  //resetting jumptimeCount

            mRB2D.velocity = Vector2.up * jumpForce;

            //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 2f), ForceMode2D.Impulse);

            skateSound.Play();
        }

        if (Input.GetButton("Jump") && isJumping == true)
        {
            if (jumpTimeCount > 0)
            {
                //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 2f), ForceMode2D.Impulse);

                mRB2D.velocity = Vector2.up * jumpForce;
                jumpTimeCount -= Time.deltaTime;
            } else
            {
                isJumping = false;
            }
        }

        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
        }



        if (isLanded == false)
        {
            anima.SetBool("isJumping", true);
        }
        else
        {
            anima.SetBool("isJumping", false);
        }


        




        if (Input.GetButtonDown("Crouch"))
        {


            anima.SetBool("isCrouching", true);

        }


        
        else if (Input.GetButtonUp("Crouch"))
        {

         
            anima.SetBool("isCrouching", false);

        }








        if (Input.GetKey(KeyCode.UpArrow) && (timeBtwKick <= 0))
        {

            anima.SetBool("isPushing", true);
            kickSound.Play();

            Collider2D[] objsToKick = Physics2D.OverlapCircleAll(kickPos.position, kickRange, kickableGroup);

            

            for (int i = 0; i < objsToKick.Length; i++)
            {

    
                objsToKick[i].GetComponent<BreakableObject>().BoxDestr();
                //objsToKick[i].GetComponent<RatEnemy>().EnemyDefeated();
               // objsToKick[i].GetComponent<TrashCan>().Can();

            }

          
            timeBtwKick = startTimeBtwKick; //reset timer

        }
        else
        {
            anima.SetBool("isPushing", false);
            timeBtwKick -= Time.deltaTime;

        }




        //throwing shoe ability, unlocked by purchasing ninja lisko



        /*

        if (shootingShoes == true)  //checking if the upgrade was actually purchased
        {
            canShoot = true;

            //check if button is pressed, 

            if (Input.GetKey(KeyCode.DownArrow) && (timeBtwKick <= 0) && (canShoot == true))
            {

                anima.SetBool("isPushing", true); //animation triggers

                kickSound.Play();  //sound plays

                if (facingRight == true) //checking player's direction
                {
          
                    Instantiate(spawnShoe, kickPos.position, kickPos.rotation); //instantiate the shoe
                    transform.localRotation = Quaternion.Euler(0, 0, 0);


                } else if (facingRight == false)
                {
                    Instantiate(spawnShoe, kickPos.position, kickPos.rotation);
                    transform.localRotation = Quaternion.Euler(0, 180, 0);

                }

                timeBtwKick = startTimeBtwKick; //reset timer

            }

            else
            {

                timeBtwKick -= Time.deltaTime; //time btw kick minus the seconds it took 
                                               //for the engine to process the previous frame
            }

        } else if (shootingShoes == false) {

            canShoot = false;
            anima.SetBool("isPushing", false);

        }


        */





        
        if (shootingShoes == true)  //checking if the upgrade was actually purchased
        {

                if (Input.GetKey(KeyCode.DownArrow) && (timeBtwKick <= 0))
                {
                    anima.SetBool("isPushing", true);



                if ((Input.GetKey(KeyCode.DownArrow)))
                {
                    canShoot = true;

                    kickSound.Play();
                    Instantiate(spawnShoe, kickPos.position, kickPos.rotation);



                }
                else if (shootingShoes == false)
                    {
                        canShoot = false;
                        anima.SetBool("isPushing", false);
              
                    }

                    timeBtwKick = startTimeBtwKick; //reset timer

                }
                else 
                {

                    timeBtwKick -= Time.deltaTime;
                }

        }
 


        //jumping higher, unlocked by purchasing ange lisko

        if (jumpHigherAnge == true)
        {
            jumpForce = 4f;


        } else
        {

            jumpForce = 3.5f;

        }





        //unlocking special doors abilities and skating faster ability, unlocked by purchasing rainbow lisko

  
    

        if (isFalling == true || PlayerHB.lifebar == 0)
        {



            LiskoLifeScript.liskoValue -= 1;
            //Debug.Log("GAME OVER");         
            anima.SetBool("isDead", true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      

        }







     
 



        float tHorizontal = Input.GetAxis("Horizontal"); //Get left/right

        mRB2D.velocity = new Vector2(tHorizontal * skaterSpeed, mRB2D.velocity.y);


        if (Input.GetAxis("Horizontal") > 0.5f)
        {

            anima.SetBool("isWalking", true);

            movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * skaterSpeed * Time.deltaTime, 0f, 0f));
            facingRight = true;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
           // transform.localScale = new Vector3(1, 1, 1);



        }
        else if (Input.GetAxis("Horizontal") < -0.5f)
        {
            anima.SetBool("isWalking", true);
            movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * -skaterSpeed * Time.deltaTime, 0f, 0f));
            facingRight = false;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
           // transform.localScale = new Vector3(-1, 1, 1);



        }
        else
        {
            anima.SetBool("isWalking", false);
        }


    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(kickPos.position, kickRange);
    }




    private void OnTriggerEnter2D(Collider2D colli)
    {




        if (colli.gameObject.tag.Equals("tEnemy") && PlayerHB.lifebar > 0)
        {

            hitSound.Play();
            Debug.Log("Auch!");
            PlayerHB.lifebar += -1;
            StartCoroutine("Invulnerable");
            anima.SetTrigger("isHurting");
            StartCoroutine("Suffering");
       


        }


        if (colli.gameObject.tag.Equals("tPlof") && PlayerHB.lifebar > 0)
        {

            //Debug.Log("Auch!");
            PlayerHB.lifebar += -1;
            StartCoroutine("Invulnerable");
            anima.SetTrigger("isHurting");
            StartCoroutine("Suffering");
            plof.Play();


        }




    }


    private void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.tag.Equals("tEnemy"))
        {

            
            StartCoroutine("JumpingOnEnemy");



        }


        if (col.gameObject.tag.Equals("tGround"))
        {


            this.transform.parent = col.transform;            //allows platform to carry player 



        }
 




        if (col.gameObject.tag.Equals("tBall") && PlayerHB.lifebar > 0)
        {

           // Debug.Log("Auch!");
            PlayerHB.lifebar += -1;
            StartCoroutine("Invulnerable");
            anima.SetTrigger("isHurting");
            StartCoroutine("Suffering");

            wheelExplodes.Play();
           // playerHit.Play();


        }


   

      
    }






    private void OnCollisionExit2D(Collision2D col)
    {


        if (col.gameObject.tag.Equals("tGround"))
        {


            this.transform.parent = null;        //leave platform



        }
       
    }







    IEnumerator Suffering()
    {

       

        isHurting = true;

        mRB2D.velocity = Vector2.zero;



        if (facingRight)
        {

            //mRB2D.AddForce(new Vector2(-5f, 5f));    //makes the player "jump" back after hurt
                                                     //still did not get why the facing right first number WAS negative (I changed it)


            mRB2D.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.3f, 0f), ForceMode2D.Impulse);


        }
        else
        {
            // mRB2D.AddForce(new Vector2(5f, -5f));

            mRB2D.GetComponent<Rigidbody2D>().AddForce(new Vector2(-0.3f, 0f), ForceMode2D.Impulse);

            yield return new WaitForSeconds(0f);
   
        }





    }




    IEnumerator Invulnerable()
    {
        Physics2D.IgnoreLayerCollision(9, 10, true);  //NB: MAKE SURE ALL THE ENEMIES ARE ON LAYER 10, ("Enemies"), 
                                                      //OR THE COLLISION WON'T BE IGNORED AND PLAYER WON'T BE INVULNERABLE!!

      

        invisible.a = 0.5f;     //a = alpha component of the color, 0 is transparent, 1 is opaque
        render.material.color = invisible;

        yield return new WaitForSeconds(2f);  //wait 1 sec


        Physics2D.IgnoreLayerCollision(9, 10, false);


        invisible.a = 1f;
        render.material.color = invisible;
    }


    IEnumerator JumpingOnEnemy()
    {



        if (facingRight)
        {

           // mRB2D.AddForce(new Vector2(15f, 50f));    //makes the player bounce on enemy 
            mRB2D.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.2f, 0.7f), ForceMode2D.Impulse);




        }
        else
        {

           
            //mRB2D.AddForce(new Vector2(-15f, 50f));

            mRB2D.GetComponent<Rigidbody2D>().AddForce(new Vector2(-0.2f, 0.5f), ForceMode2D.Impulse);
            yield return new WaitForSeconds(0f);
    

        }





    }
}









