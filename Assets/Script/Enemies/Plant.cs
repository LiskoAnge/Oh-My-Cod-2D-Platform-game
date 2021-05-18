using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{

    Rigidbody2D rgB;

    public AudioSource plantSound;
    public AudioSource playerHit;


    // Start is called before the first frame update
    void Start()
    {
        rgB = GetComponent<Rigidbody2D>();
    }



    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag.Equals ("tPlayer"))
        {
            plantSound.Play();
            rgB.isKinematic = false;

        }


        
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag.Equals("tGround"))
        {
            Debug.Log("Smashed on the ground!");
       
            Destroy(gameObject);

        }

        else if (coll.gameObject.tag.Equals("tPlayer")) {

            Debug.Log("Auch!");
            PlayerHB.lifebar += -1;
            playerHit.Play();
            Destroy(gameObject);
            




        }







    }






   








    // Update is called once per frame
    void Update()
    {
        
    }
}
