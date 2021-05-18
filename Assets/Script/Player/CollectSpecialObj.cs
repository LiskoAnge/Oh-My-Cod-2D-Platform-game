using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSpecialObj : MonoBehaviour
{

    private SpecialObj specialObj;


    
    void Start()
    {

        specialObj = GameObject.FindGameObjectWithTag("tPlayer").GetComponent<SpecialObj>();
    }

 
    void Update()
    {
        
    }




    private void OnTriggerEnter2D(Collider2D colli)
    {

        if (colli.gameObject.tag.Equals("tPlayer"))
        {
            
           
        }

    }
}
