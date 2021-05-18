using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LitterScript : MonoBehaviour
{
    public static int litterValue = 0;

    Text litter;
    public AudioSource itemSold;
    public AudioSource notEnoughLitter;


    public GameObject noLitterText;






    void Start()
    {
        litter = GetComponent<Text>();

        noLitterText.SetActive(false);

        litterValue = PlayerPrefs.GetInt("litterAmount");
    }


    void Update()
    {
        litter.text = "" + litterValue;
        PlayerPrefs.SetInt("litterAmount", litterValue);



        if (PlayerHB.lifebar > 0)
        {
      


            litter.text = "" + litterValue;
            PlayerPrefs.SetInt("litterAmount", litterValue);


        }


        if (litterValue <= 0)
        {


            litterValue = 0;
        }




    }






    public void OnMouseClick()
    {



        if (litterValue >= 7)
        {


          
            litterValue -= 7;
            ScoreScript.scoreValue += 400;


        }
        else if (litterValue < 7)
        {

            noLitterText.SetActive(true);
            notEnoughLitter.Play();

        }
        else
        {
            noLitterText.SetActive(false);

        }


    }
}
