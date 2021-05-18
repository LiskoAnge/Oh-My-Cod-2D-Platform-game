using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintSystem : MonoBehaviour
{

    public GameObject infoPanel;

    private bool hSystemOn;
    private bool hSOpenClose;



    void Start()
    {

        infoPanel.SetActive(false);
    }





    private void OnTriggerStay2D(Collider2D coll)
    {


       if (coll.gameObject.tag.Equals("tPlayer"))
        {

            hSystemOn = true;

        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {

        infoPanel.SetActive(false);
        hSystemOn = false;

    }



    private void Update()
    {
      
        if (Input.GetButtonDown("Submit"))
        {
            if (hSystemOn == true)
            {

                infoPanel.SetActive(true);
                hSystemOn = true;

            } else
            {
                infoPanel.SetActive(false);
                hSystemOn = false;
                infoPanel.SetActive(false);
            }
         
        }
    }
    


}
