using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BM : MonoBehaviour
{
    public GameObject Box1, Box2, Box3, Box4, Box5, Box6, Box7;
    public static int boxesBar;




    void Start()
    {



        boxesBar = 5;
        Box1.gameObject.SetActive(true);
        Box2.gameObject.SetActive(true);
        Box3.gameObject.SetActive(true);
        Box4.gameObject.SetActive(true);
        Box5.gameObject.SetActive(true);
        Box6.gameObject.SetActive(true);
        Box7.gameObject.SetActive(true);

    }

    void Update()
    {
        if (boxesBar > 7)
            boxesBar = 7;

        switch (boxesBar)
        {
            case 7:
                Box1.gameObject.SetActive(true);
                Box2.gameObject.SetActive(true);
                Box3.gameObject.SetActive(true);
                Box4.gameObject.SetActive(true);
                Box5.gameObject.SetActive(true);
                Box6.gameObject.SetActive(true);
                Box7.gameObject.SetActive(true);
                break;
            case 6:
                Box1.gameObject.SetActive(true);
                Box2.gameObject.SetActive(true);
                Box3.gameObject.SetActive(true);
                Box4.gameObject.SetActive(true);
                Box5.gameObject.SetActive(true);
                Box6.gameObject.SetActive(true);
                Box7.gameObject.SetActive(false);
                break;
            case 5:
                Box1.gameObject.SetActive(true);
                Box2.gameObject.SetActive(true);
                Box3.gameObject.SetActive(true);
                Box4.gameObject.SetActive(true);
                Box5.gameObject.SetActive(true);
                Box6.gameObject.SetActive(false);
                Box7.gameObject.SetActive(false);
                break;
            case 4:
                Box1.gameObject.SetActive(true);
                Box2.gameObject.SetActive(true);
                Box3.gameObject.SetActive(true);
                Box4.gameObject.SetActive(true);
                Box5.gameObject.SetActive(false);
                Box6.gameObject.SetActive(false);
                Box7.gameObject.SetActive(false);
                break;
            case 3:
                Box1.gameObject.SetActive(true);
                Box2.gameObject.SetActive(true);
                Box3.gameObject.SetActive(true);
                Box4.gameObject.SetActive(false);
                Box5.gameObject.SetActive(false);
                Box6.gameObject.SetActive(false);
                Box7.gameObject.SetActive(false);
                break;
            case 2:
                Box1.gameObject.SetActive(true);
                Box2.gameObject.SetActive(true);
                Box3.gameObject.SetActive(false);
                Box4.gameObject.SetActive(false);
                Box5.gameObject.SetActive(false);
                Box6.gameObject.SetActive(false);
                Box7.gameObject.SetActive(false);
                break;
            case 1:
                Box1.gameObject.SetActive(true);
                Box2.gameObject.SetActive(false);
                Box3.gameObject.SetActive(false);
                Box4.gameObject.SetActive(false);
                Box5.gameObject.SetActive(false);
                Box6.gameObject.SetActive(false);
                Box7.gameObject.SetActive(false);
                break;

            case 0:
                boxesBar = 0;

                Box1.gameObject.SetActive(false);
                Box2.gameObject.SetActive(false);
                Box3.gameObject.SetActive(false);
                Box4.gameObject.SetActive(false);
                Box5.gameObject.SetActive(false);
                Box6.gameObject.SetActive(false);
                Box7.gameObject.SetActive(false);
                break;




        }






    }
}
