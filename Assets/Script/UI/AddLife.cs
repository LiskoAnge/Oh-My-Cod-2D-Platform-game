using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLife : MonoBehaviour
{


    public AudioSource hpSound;




    private void OnTriggerEnter2D(Collider2D colli)
    {

        if (colli.gameObject.tag.Equals("tPlayer") && PlayerHB.lifebar < 5)
        {


            //Debug.Log("Life restored");
            PlayerHB.lifebar += 1;
            Destroy(gameObject);
            hpSound.Play();
     
  
        }


      

    }


}
