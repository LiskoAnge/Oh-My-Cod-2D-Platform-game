﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

 




    void Start()
    {


        score = GetComponent<Text>();

        scoreValue = PlayerPrefs.GetInt("coinsAmount");

        
    }

    
    void Update()
    {
        score.text = "" + scoreValue;
        PlayerPrefs.SetInt("coinsAmount", scoreValue);



        if (PlayerHB.lifebar > 0)
        {
           // totalscore = (int)Time.time + enemiesKilledScore;
           // scoretext.text = totalScore.ToString();



            score.text = "" + scoreValue;
            PlayerPrefs.SetInt("coinsAmount", scoreValue);


        }



        if (scoreValue <= 0)
        {


            scoreValue = 0;
        }







    }
}
