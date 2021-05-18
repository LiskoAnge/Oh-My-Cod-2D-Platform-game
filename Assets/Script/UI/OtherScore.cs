using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OtherScore : MonoBehaviour
{
    

    public static int otherScoreValue = 0;
    Text otherScore;



    void Start()
    {
        otherScore = GetComponent<Text>();

        otherScoreValue = PlayerPrefs.GetInt("purpleCoinsAmount");
    }

    void Update()
    {
        otherScore.text = "" + otherScoreValue;
        PlayerPrefs.SetInt("purpleCoinsAmount", otherScoreValue);


        if (PlayerHB.lifebar > 0)
        {
  
            otherScore.text = "" + otherScoreValue;
            PlayerPrefs.SetInt("purpleCoinsAmount", otherScoreValue);


        }


        //avoid user diying on purpose to collect more purple coins at once!!

        if (otherScoreValue >= 2)   
        {
            otherScoreValue = 1;
        }




    }


 

}
