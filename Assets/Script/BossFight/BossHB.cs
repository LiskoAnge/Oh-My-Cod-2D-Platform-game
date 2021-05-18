using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHB : MonoBehaviour
{


    public GameObject BossHB1, BossHB2, BossHB3, BossHB4, BossHB5, BossHB6, BossHB7, BossHB8, BossHB9, BossHB10;
    public static int bossLifeBar;








    void Start()
    {

        bossLifeBar = 10;

        BossHB1.gameObject.SetActive(true);
        BossHB2.gameObject.SetActive(true);
        BossHB3.gameObject.SetActive(true);
        BossHB4.gameObject.SetActive(true);
        BossHB5.gameObject.SetActive(true);
        BossHB6.gameObject.SetActive(true);
        BossHB7.gameObject.SetActive(true);
        BossHB8.gameObject.SetActive(true);
        BossHB9.gameObject.SetActive(true);
        BossHB10.gameObject.SetActive(true);


    }


    void Update()
    {

        if (bossLifeBar > 10)
            bossLifeBar = 10;

        switch (bossLifeBar)
        {

            case 10:
                BossHB1.gameObject.SetActive(true);
                BossHB2.gameObject.SetActive(true);
                BossHB3.gameObject.SetActive(true);
                BossHB4.gameObject.SetActive(true);
                BossHB5.gameObject.SetActive(true);
                BossHB6.gameObject.SetActive(true);
                BossHB7.gameObject.SetActive(true);
                BossHB8.gameObject.SetActive(true);
                BossHB9.gameObject.SetActive(true);
                BossHB10.gameObject.SetActive(true);

                break;
            case 9:
                BossHB1.gameObject.SetActive(true);
                BossHB2.gameObject.SetActive(true);
                BossHB3.gameObject.SetActive(true);
                BossHB4.gameObject.SetActive(true);
                BossHB5.gameObject.SetActive(true);
                BossHB6.gameObject.SetActive(true);
                BossHB7.gameObject.SetActive(true);
                BossHB8.gameObject.SetActive(true);
                BossHB9.gameObject.SetActive(true);
                BossHB10.gameObject.SetActive(false);

                break;
            case 8:
                BossHB1.gameObject.SetActive(true);
                BossHB2.gameObject.SetActive(true);
                BossHB3.gameObject.SetActive(true);
                BossHB4.gameObject.SetActive(true);
                BossHB5.gameObject.SetActive(true);
                BossHB6.gameObject.SetActive(true);
                BossHB7.gameObject.SetActive(true);
                BossHB8.gameObject.SetActive(true);
                BossHB9.gameObject.SetActive(false);
                BossHB10.gameObject.SetActive(false);

                break;

            case 7:

                BossHB1.gameObject.SetActive(true);
                BossHB2.gameObject.SetActive(true);
                BossHB3.gameObject.SetActive(true);
                BossHB4.gameObject.SetActive(true);
                BossHB5.gameObject.SetActive(true);
                BossHB6.gameObject.SetActive(true);
                BossHB7.gameObject.SetActive(true);
                BossHB8.gameObject.SetActive(false);
                BossHB9.gameObject.SetActive(false);
                BossHB10.gameObject.SetActive(false);

                break;
            case 6:
                BossHB1.gameObject.SetActive(true);
                BossHB2.gameObject.SetActive(true);
                BossHB3.gameObject.SetActive(true);
                BossHB4.gameObject.SetActive(true);
                BossHB5.gameObject.SetActive(true);
                BossHB6.gameObject.SetActive(true);
                BossHB7.gameObject.SetActive(false);
                BossHB8.gameObject.SetActive(false);
                BossHB9.gameObject.SetActive(false);
                BossHB10.gameObject.SetActive(false);

                break;
            case 5:
                BossHB1.gameObject.SetActive(true);
                BossHB2.gameObject.SetActive(true);
                BossHB3.gameObject.SetActive(true);
                BossHB4.gameObject.SetActive(true);
                BossHB5.gameObject.SetActive(true);
                BossHB6.gameObject.SetActive(false);
                BossHB7.gameObject.SetActive(false);
                BossHB8.gameObject.SetActive(false);
                BossHB9.gameObject.SetActive(false);
                BossHB10.gameObject.SetActive(false);

                break;
            case 4:
                BossHB1.gameObject.SetActive(true);
                BossHB2.gameObject.SetActive(true);
                BossHB3.gameObject.SetActive(true);
                BossHB4.gameObject.SetActive(true);
                BossHB5.gameObject.SetActive(false);
                BossHB6.gameObject.SetActive(false);
                BossHB7.gameObject.SetActive(false);
                BossHB8.gameObject.SetActive(false);
                BossHB9.gameObject.SetActive(false);
                BossHB10.gameObject.SetActive(false);

                break;

            case 3:

                BossHB1.gameObject.SetActive(true);
                BossHB2.gameObject.SetActive(true);
                BossHB3.gameObject.SetActive(true);
                BossHB4.gameObject.SetActive(false);
                BossHB5.gameObject.SetActive(false);
                BossHB6.gameObject.SetActive(false);
                BossHB7.gameObject.SetActive(false);
                BossHB8.gameObject.SetActive(false);
                BossHB9.gameObject.SetActive(false);
                BossHB10.gameObject.SetActive(false);

                break;
            case 2:

                BossHB1.gameObject.SetActive(true);
                BossHB1.gameObject.SetActive(true);
                BossHB2.gameObject.SetActive(false);
                BossHB3.gameObject.SetActive(false);
                BossHB4.gameObject.SetActive(false);
                BossHB5.gameObject.SetActive(false);
                BossHB6.gameObject.SetActive(false);
                BossHB7.gameObject.SetActive(false);
                BossHB8.gameObject.SetActive(false);
                BossHB9.gameObject.SetActive(false);
                BossHB10.gameObject.SetActive(false);

                break;

            case 1:


                BossHB1.gameObject.SetActive(true);
                BossHB1.gameObject.SetActive(false);
                BossHB2.gameObject.SetActive(false);
                BossHB3.gameObject.SetActive(false);
                BossHB4.gameObject.SetActive(false);
                BossHB5.gameObject.SetActive(false);
                BossHB6.gameObject.SetActive(false);
                BossHB7.gameObject.SetActive(false);
                BossHB8.gameObject.SetActive(false);
                BossHB9.gameObject.SetActive(false);
                BossHB10.gameObject.SetActive(false);


                break;

            case 0:

                bossLifeBar = 0;

                BossHB1.gameObject.SetActive(false);
                BossHB1.gameObject.SetActive(false);
                BossHB2.gameObject.SetActive(false);
                BossHB3.gameObject.SetActive(false);
                BossHB4.gameObject.SetActive(false);
                BossHB5.gameObject.SetActive(false);
                BossHB6.gameObject.SetActive(false);
                BossHB7.gameObject.SetActive(false);
                BossHB8.gameObject.SetActive(false);
                BossHB9.gameObject.SetActive(false);
                BossHB10.gameObject.SetActive(false);


                break;




        }



    }







}
