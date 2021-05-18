using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class BossScript : MonoBehaviour
{

    Rigidbody2D rb;
    Animator anim;
    public float bossSpeed = 2.3f;
    public GameObject spawnBullet;
    public GameObject bossLifeBar;

    public float maxTime = 5;
    public float minTime = 3;
    private bool facingRight;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;
    private float speed = 1.0f; //how fast it shakes
    private float amount = 1.0f; //how much it shakes

    public AudioSource plof;
    public AudioSource seagHurt;

    public AnimatorOverrideController redBoss;



    void Start()
    {
        SetRandomTime();
        time = minTime;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        bossLifeBar.SetActive(true);




    }

    void FixedUpdate()
    {

        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }

    }

    //Spawns the object and resets the time
    void SpawnObject()
    {

        StartCoroutine("BossisAttacking");
  

    }



    IEnumerator BossisAttacking()
    {

        time = 0;
        //Instantiate(spawnBullet, transform.position, spawnBullet.transform.rotation);


        Instantiate(spawnBullet, transform.position, Quaternion.identity);

        plof.Play();
        bossSpeed = 0;
        anim.SetBool("bossAttacks", true);
        yield return new WaitForSeconds(1f);
        anim.SetBool("bossAttacks", false);
        bossSpeed = 2;

    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }




    void Update()
    {




        if (facingRight == true)
        {
            rb.velocity = new Vector2(bossSpeed, 0f);
            transform.localRotation = Quaternion.Euler(0, 180, 0);

        } else if (facingRight == false)
        {
            rb.velocity = new Vector2(-bossSpeed, 0f);
            transform.localRotation = Quaternion.Euler(0, 0, 0);

        }



        if (BossHB.bossLifeBar <= 5)
        {

            GetComponent<Animator>().runtimeAnimatorController = redBoss as RuntimeAnimatorController;
            //the enemy boss turns red, is faster and shoots more frequently
            bossSpeed = 2.7f;                      
            minTime = 2;
            maxTime = 3.5f;


        }


        if (BossHB.bossLifeBar == 0)
        {


            StartCoroutine("BossDeath");
            


            //the enemy boss turns red, is faster and shoots more frequently
         


        }




    }



    private void OnTriggerEnter2D(Collider2D colli)
    {



        if (colli.gameObject.tag.Equals("tStop"))
        {
            facingRight = true;
            //transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);

        
        }

        if (colli.gameObject.tag.Equals("tStop2"))
        {
            facingRight = false;
            //transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);


        }


        if (colli.gameObject.tag == "tPlayerBullet")
        {

         
            seagHurt.Play();
            StartCoroutine("BossisHurt");

      

        }



    }

    IEnumerator BossisHurt()
    {

        time = 0;
        BossHB.bossLifeBar += -1;

        anim.SetBool("bossHurts", true);
        yield return new WaitForSeconds(0.25f);
        anim.SetBool("bossHurts", false);

    }


    IEnumerator BossDeath()
    {
        anim.SetTrigger("bossDeath");
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(13);


    }







}