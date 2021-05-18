using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActive : MonoBehaviour
{

    public GameObject RatBossHB;


    void Start()
    {
        RatBossHB.SetActive(false);
    }

    void Update()
    {

        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag.Equals("tPlayer"))
        {

            RatBossHB.SetActive(true);


        }



    }
}
