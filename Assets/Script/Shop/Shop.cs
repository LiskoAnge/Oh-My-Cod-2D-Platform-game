using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{


    public GameObject shopPanel;



    //Animator ani;




    void Start()
    {

        shopPanel.SetActive(false);
        
        // ani = GetComponent<Animator>();


    }


   


    private void OnTriggerEnter2D(Collider2D colli)
    {

        if (colli.gameObject.tag.Equals("tPlayer"))
        {

            //ani.SetTrigger("isWaving");


            shopPanel.SetActive(true);
            Debug.Log("Accessing shop..");


           




        }



    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        shopPanel.SetActive(false);
   
    }
}
