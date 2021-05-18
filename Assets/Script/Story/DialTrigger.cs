using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    public GameObject skater;



    private void Start()
    {
        skater = GameObject.FindGameObjectWithTag("tPlayer").gameObject;
    }

    public void TriggerDial()
    {
        FindObjectOfType<DM>().StartDialogue(dialogue);

    }




    




    private void OnTriggerEnter2D(Collider2D colli)
    {
        if (colli.gameObject.tag.Equals("tPlayer"))
        {




            Time.timeScale = 0;   //stop game
      

            TriggerDial();
            
            Debug.Log("collision with player");




            

   

         


        }
    }

    

}
