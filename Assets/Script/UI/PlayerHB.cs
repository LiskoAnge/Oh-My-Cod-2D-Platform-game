using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHB : MonoBehaviour
{
    public GameObject Life1, Life2, Life3, Life4, Life5;
    public static int lifebar;

    //    Save positionData;



    public bool isFalling;
    public BackToMap backToMap;


    void Start()
    {

        //positionData = FindObjectOfType<Save>();
        lifebar = 5;
        Life1.gameObject.SetActive(true);
        Life2.gameObject.SetActive(true);
        Life3.gameObject.SetActive(true);
        Life4.gameObject.SetActive(true);
        Life5.gameObject.SetActive(true);



    }

    void Update()
    {
        if (lifebar > 5)
            lifebar = 5;

        switch (lifebar)
        {

            case 5:

                Life1.gameObject.SetActive(true);
                Life2.gameObject.SetActive(true);
                Life3.gameObject.SetActive(true);
                Life4.gameObject.SetActive(true);
                Life5.gameObject.SetActive(true);
                break;

            case 4:

                Life1.gameObject.SetActive(true);
                Life2.gameObject.SetActive(true);
                Life3.gameObject.SetActive(true);
                Life4.gameObject.SetActive(true);
                Life5.gameObject.SetActive(false);
                break;

            case 3:

                Life1.gameObject.SetActive(true);
                Life2.gameObject.SetActive(true);
                Life3.gameObject.SetActive(true);
                Life4.gameObject.SetActive(false);
                Life5.gameObject.SetActive(false);
                break;


            case 2:

                Life1.gameObject.SetActive(true);
                Life2.gameObject.SetActive(true);
                Life3.gameObject.SetActive(false);
                Life4.gameObject.SetActive(false);
                Life5.gameObject.SetActive(false);


                break;
            case 1:

                Life1.gameObject.SetActive(true);
                Life2.gameObject.SetActive(false);
                Life3.gameObject.SetActive(false);
                Life4.gameObject.SetActive(false);
                Life5.gameObject.SetActive(false);

                break;

            case 0:

                lifebar = 0;

                Life1.gameObject.SetActive(false);
                Life2.gameObject.SetActive(false);
                Life3.gameObject.SetActive(false);
                Life4.gameObject.SetActive(false);
                Life5.gameObject.SetActive(false);

                break;
                



        }

        






    }








}
