using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    private GameMaster gameMaster;
    Animator ani;


    public AudioSource fountain;


    private void Start()
    {

    
        ScoreScript.scoreValue -= 100;  //player loses some golden coins when dies as penalty and to avoid users to die on purpose to collect more coins
        PlayerPrefs.SetInt("coinsAmount", ScoreScript.scoreValue);


        LitterScript.litterValue -= 1;
        PlayerPrefs.SetInt("litterAmount", LitterScript.litterValue);



        gameMaster = GameObject.FindGameObjectWithTag("tGameMaster").GetComponent<GameMaster>();

        ani = GetComponent<Animator>();

    }

 

    void OnTriggerEnter2D(Collider2D other)
     {


  
        if (other.gameObject.tag.Equals("tPlayer"))

        {

            fountain.Play();
            gameMaster.lastCheckPointPos = transform.position;
            ani.SetBool("checkPoint", true);
            Debug.Log("checkpoint detected");

        }

     
     }

}
