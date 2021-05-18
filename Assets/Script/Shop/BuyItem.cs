using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{



    int isLiskoNinja;
    int isLiskoAnge;
    int isLiskoRainbow;

    public AnimatorOverrideController darkSkaterAnim;
    public AnimatorOverrideController angeLiskoAnim;
    public AnimatorOverrideController rainbowLiskoAnim;


    public AudioSource notEnoughCoins;
    public AudioSource itemSold;

    public GameObject noCoinsText;
    public GameObject noCoinsWhiteText;
    public GameObject noCoinsRainbowText;


    public SkaterMoves skMoves;


    private void Start()
    {
        
        noCoinsText.SetActive(false);
        noCoinsWhiteText.SetActive(false);
        noCoinsRainbowText.SetActive(false);
    }

    private void Update()
    {
        isLiskoNinja = PlayerPrefs.GetInt("ninjaLis");

        isLiskoAnge = PlayerPrefs.GetInt("angeLis");

        isLiskoRainbow = PlayerPrefs.GetInt("rainbowLis");
    }




    public void BuyDarkLiskoOnClick()
    {

     


        if  (ScoreScript.scoreValue >= 700)
        {

            PlayerPrefs.DeleteKey("angeLis");
            PlayerPrefs.DeleteKey("rainbowLis");

            PlayerPrefs.SetInt("ninjaLis", 1);
            GetComponent<Animator>().runtimeAnimatorController = darkSkaterAnim as RuntimeAnimatorController;
            skMoves.shootingShoes = true;
            skMoves.jumpHigherAnge = false;
            skMoves.secretRainbow = false;
            itemSold.Play();
            ScoreScript.scoreValue += -700;








        }


        else if (ScoreScript.scoreValue < 700)
        {

            noCoinsText.SetActive(true);
            notEnoughCoins.Play();

        }
        else
        {

           
            noCoinsText.SetActive(false);

        }


    }


    public void BuyAngeLiskoOnClick()
    {


        if (ScoreScript.scoreValue >= 700)
        {
            itemSold.Play();
            PlayerPrefs.DeleteKey("ninjaLis");
            PlayerPrefs.DeleteKey("rainbowLis");
            skMoves.shootingShoes = false;
            skMoves.secretRainbow = false;
            skMoves.jumpHigherAnge = true;
            PlayerPrefs.SetInt("angeLis", 2);
            GetComponent<Animator>().runtimeAnimatorController = angeLiskoAnim as RuntimeAnimatorController;
       
            ScoreScript.scoreValue += -700;


        }


        else if (ScoreScript.scoreValue < 700)
        {

            noCoinsWhiteText.SetActive(true);
            notEnoughCoins.Play();

        }
        else
        {
            noCoinsWhiteText.SetActive(false);

        }

    }



    public void BuyRainbowLiskoOnClick()
    {

        if (ScoreScript.scoreValue >= 700)
        {
            PlayerPrefs.DeleteKey("ninjaLis");
            PlayerPrefs.DeleteKey("angeLis");
            skMoves.shootingShoes = false;
            skMoves.jumpHigherAnge = false;
            skMoves.secretRainbow = true;
            PlayerPrefs.SetInt("rainbowLis", 3);
            GetComponent<Animator>().runtimeAnimatorController = rainbowLiskoAnim as RuntimeAnimatorController;
            itemSold.Play();
            ScoreScript.scoreValue += -700;
        }
        else if (ScoreScript.scoreValue < 700)
        {
            noCoinsRainbowText.SetActive(true);
            notEnoughCoins.Play();
        }
        else
        {
            noCoinsRainbowText.SetActive(false);
        }

    }







}
