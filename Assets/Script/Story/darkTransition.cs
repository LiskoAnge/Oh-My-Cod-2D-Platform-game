using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class darkTransition : MonoBehaviour
{



    //public Animator anim;
    
    private Animator anima;


    void Start()
    {
        anima = GetComponent<Animator>();

        //anim = GetComponent<Animator>();

        StartCoroutine("DarkTransition");
    }


   


    IEnumerator DarkTransition()
    {

        yield return new WaitForSeconds(9f);

        anima.SetTrigger("darkScreen");

        //anim.SetTrigger("decreaseMusic");






        yield return new WaitForSeconds(2f);


 
        

        SceneManager.LoadScene(3);


    }

     










}
