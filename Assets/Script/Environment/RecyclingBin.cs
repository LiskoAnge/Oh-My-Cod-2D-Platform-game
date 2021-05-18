using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecyclingBin : MonoBehaviour
{

    public GameObject recyclingPanel;

    Animator ani;

    void Start()
    {

        recyclingPanel.SetActive(false);
        ani = GetComponent<Animator>();

    }

  
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("tPlayer"))
        {

            recyclingPanel.SetActive(true);
            ani.SetBool("binsOpen", true);



        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {


        if (collision.gameObject.tag.Equals("tPlayer"))
        {

            recyclingPanel.SetActive(false);
            ani.SetBool("binsOpen", false);



        }

    }






}
