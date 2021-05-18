using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{


public AudioClip[] sounds;






    private void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "tPlayer")
        {

 

            Invoke("PlayRandomSound", 0.5f);
        }


    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }




    public void PlayRandomSound()
    {

        int randomSound = Random.Range(0, sounds.Length);
        GetComponent<AudioSource>().clip = sounds[randomSound];
        GetComponent<AudioSource>().Play();

    }



}
