using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMap : MonoBehaviour
{








    private void OnTriggerEnter2D(Collider2D colli)
    {

        if (colli.gameObject.tag.Equals("tPlayer"))
        {


            SceneManager.LoadScene(3);

        }


   
     
    }
}
