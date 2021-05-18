using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{


    public AudioSource catSound;




    private void OnTriggerEnter2D(Collider2D colli)
    {
        if (colli.gameObject.tag.Equals("tPlayer"))
        {


            Debug.Log("Collision cat player");
            catSound.Play();

        }
    }

}
