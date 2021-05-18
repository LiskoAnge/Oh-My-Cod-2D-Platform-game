using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapPlayer : MonoBehaviour
{


    [SerializeField]
    Transform[] mapPoints;

    int mapPointIndex = 0;

    // [SerializeField]
    //  Transform[] northMapPoints;

    //  int northMapPointIndex = 0;



    private int pressButton = 0;
    public GameObject lisko;


    private float playerSpeed = 10f;


    private bool facingRight;

    public AudioSource itemSold;

    private bool seafrontlvl;
    private bool restaurantlvl;
    private bool westPierlvl;
    private bool shoplvl;
    private bool recyclingbinslvl;
    private bool pavilionlvl;
    private bool lighthouselvl;


    void Start()
    {

        restaurantlvl = true;
        facingRight = true;
       // transform.position = mapPoints[mapPointIndex].transform.position;
    }


    void Update()
    {
        Moving();
        
    }


    void Moving ()
    {

        // float tHorizontal = Input.GetAxis("Horizontal"); //Get left/right

        // float tVertical = Input.GetAxis("Vertical"); //Get up/down

        transform.position = Vector2.MoveTowards(transform.position, mapPoints[mapPointIndex].transform.position, playerSpeed * Time.deltaTime);





        if (Input.GetAxis("Horizontal") > 0.5)
        {
            if (transform.position == mapPoints[0].transform.position)
            {
                mapPointIndex = 1;
                facingRight = true;
                transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            if (transform.position == mapPoints[2].transform.position)
            {
                mapPointIndex = 3;
                facingRight = true;
                transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            if (transform.position == mapPoints[4].transform.position)
            {
                mapPointIndex = 6;
                facingRight = true;
                transform.localRotation = Quaternion.Euler(0, 0, 0);

            }
            if (transform.position == mapPoints[5].transform.position)
            {
                mapPointIndex = 4;
                facingRight = true;
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            if (transform.position == mapPoints[6].transform.position)
            {
                mapPointIndex = 6;
                facingRight = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);

            }
        }


        if (Input.GetAxis("Horizontal") < -0.5)
        {


            /*

            if (transform.position == mapPoints[mapPointIndex].transform.position && mapPointIndex >= 1)
            {
                mapPointIndex -= 1;
                facingRight = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);

            }
            */

            if (transform.position == mapPoints[1].transform.position)
            {
                mapPointIndex = 0;
                facingRight = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);

            }



            if (transform.position == mapPoints[3].transform.position)
            {
                mapPointIndex = 2;
                facingRight = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);

            }



            if (transform.position == mapPoints[4].transform.position)
            {
                mapPointIndex = 5;
                facingRight = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);

            }

            if (transform.position == mapPoints[5].transform.position)
            {
                mapPointIndex = 5;
                facingRight = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);

            }


            if (transform.position == mapPoints[6].transform.position)
            {
                mapPointIndex = 4;
                facingRight = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);

            }

        }


        if (Input.GetAxis("Vertical") > 0.5)
        {


            if (transform.position == mapPoints[0].transform.position)
            {
                mapPointIndex = 4;
                facingRight = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);

            }


            if (transform.position == mapPoints[2].transform.position)
            {
                mapPointIndex = 1;
                facingRight = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);

            }

        }


        if (Input.GetAxis("Vertical") < -0.5)
        {
            if (transform.position == mapPoints[1].transform.position)
            {
                mapPointIndex = 2;
                facingRight = true;
                transform.localRotation = Quaternion.Euler(0, 0, 0);

            }

            if (transform.position == mapPoints[4].transform.position)
            {
                mapPointIndex = 0;
                facingRight = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);

            }

        }










        /*


        if (Input.GetAxis("Horizontal") > 0.5f)
        {
            transform.position = Vector2.MoveTowards(transform.position, mapPoints[mapPointIndex].transform.position, playerSpeed * Time.deltaTime);



            if (transform.position == mapPoints[mapPointIndex].transform.position)
            {
                mapPointIndex += 1;
            }

        }




        if (Input.GetAxis("Horizontal") < -0.5f)
        {
            transform.position = Vector2.MoveTowards(transform.position, mapPoints[mapPointIndex].transform.position, playerSpeed * Time.deltaTime);



            if (transform.position == mapPoints[mapPointIndex].transform.position)
            {
                mapPointIndex -= 1;


            }

        }


        */


        

        switch (mapPointIndex)
        {
            case 6:
                if (Input.GetButtonDown("Submit"))
                {
                    SceneManager.LoadScene(5);
                }


                break;

            case 5:

                if (Input.GetButtonDown("Submit"))
                {
                    SceneManager.LoadScene(11);
                }

                break;

            case 4:

                if (Input.GetButtonDown("Submit"))
                {
                    SceneManager.LoadScene(12);
                }


                break;

            case 3:

                if (Input.GetButtonDown("Submit"))
                {

                    if (ScoreScript.scoreValue >= 3000)
                    {
                        ScoreScript.scoreValue += -3000;
                        StartCoroutine("BossFightUnlocked");

                    }
                       
                }

                break;

            case 2:

                if (Input.GetButtonDown("Submit"))
                {
                    SceneManager.LoadScene(9);
                }

                break;

            case 1:


                if (Input.GetButtonDown("Submit"))
                {
                    SceneManager.LoadScene(7);
                }
                break;


            case 0:


                break;



        }




        
        /*
        if (Input.GetAxis("Vertical") > 0.5f && restaurantlvl == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, mapPoints[1].transform.position, playerSpeed * Time.deltaTime);
            recyclingbinslvl = true;
        } 


        if (Input.GetAxis("Horizontal") > 0.5f && restaurantlvl == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, mapPoints[3].transform.position, playerSpeed * Time.deltaTime);

            seafrontlvl = true;
        


            // movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            //transform.Translate(new Vector3(Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime, 0f, 0f));


       
           // transform.localRotation = Quaternion.Euler(0, 0, 0);




        }


        if (Input.GetAxis("Vertical") < -0.5f && seafrontlvl == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, mapPoints[4].transform.position, -playerSpeed * Time.deltaTime);

            westPierlvl = true;
            //movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            //transform.Translate(new Vector3(Input.GetAxis("Horizontal") * -playerSpeed * Time.deltaTime, 0f, 0f));
            // facingRight = false;
            // transform.localRotation = Quaternion.Euler(0, 180, 0);




        }



    
        /*


        transform.position = Vector2.MoveTowards(transform.position, mapPoints[mapPointIndex].transform.position, playerSpeed * Time.deltaTime);






        if (transform.position == mapPoints[mapPointIndex].transform.position)
        {
            mapPointIndex += 1;

        }

        if (mapPointIndex == mapPoints.Length)
        {
            mapPointIndex = 0;
        }



        */
    }



    IEnumerator BossFightUnlocked()
    {

        ScoreScript.scoreValue += -100;
        itemSold.Play();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(6);

    }


 

}
