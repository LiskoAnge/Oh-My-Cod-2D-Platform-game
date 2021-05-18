using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStory : MonoBehaviour
{

    void Start()
    {

       

    }

    void Update()
    {

        StartCoroutine(NextScene());

        
    }





    IEnumerator NextScene()
    {


        yield return new WaitForSeconds(45f);

        SceneManager.LoadScene(2);

    }


 
}
