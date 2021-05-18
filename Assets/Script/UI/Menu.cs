using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;// Required when using Event data.

public class Menu : MonoBehaviour
{

    public bool resPosition;
    public AudioSource buttonPressed;
    public GameObject controlsPanel;

    //public Animator transitionAnim;

    private float transitionSec = 1;



    private void Awake()
    {
        Time.timeScale = 1;
    }


    private void Start()
    {
        controlsPanel.SetActive(false);
        // transitionAnim = GetComponent<Animator>();
    }



    public void OnMenuClick()
    {


        SceneManager.LoadScene(0);

    }

    public void OnQuitButtonMenu()
    {
        SceneManager.LoadScene(0);
    }




    public void OnNewGameClick()
    {

        StartCoroutine("Transition");

    }



    IEnumerator Transition()
    {

        ScoreScript.scoreValue = 0;

        LiskoLifeScript.liskoValue = 3;

        PlayerPrefs.DeleteAll(); //reset score, skin, etc...

        //  transitionAnim.SetTrigger("darkScreen");

        buttonPressed.Play();
        yield return new WaitForSeconds(transitionSec);

        SceneManager.LoadScene(1);
    }


    public void ContinueAfterDeath()
    {

        StartCoroutine("TryGameAgain");

    }


    IEnumerator TryGameAgain()
    {


        buttonPressed.Play();
        // transitionAnim.SetTrigger("darkScreen");
        yield return new WaitForSeconds(transitionSec);
        SceneManager.LoadScene(3);


    }

    public void OnContinueClick()
    {

        StartCoroutine("ContinueTransition");

    }


    public void QuitGameOnClick()
    {

        Application.Quit();

    }

    public void OpenControlsOnClick()
    {

        controlsPanel.SetActive(true);



    }



    IEnumerator ContinueTransition()
    {


        buttonPressed.Play();
        // transitionAnim.SetTrigger("darkScreen");
        yield return new WaitForSeconds(transitionSec);
        SceneManager.LoadScene(3);
    }













    /*


    public void nextScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }


    IEnumerator LoadScene(int lvlIndex)
    {
        ScoreScript.scoreValue = 0;      //reset score, position, etc...

        PlayerPrefs.DeleteAll();
        

        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionSec);

        SceneManager.LoadScene(lvlIndex);

    }



    */
}

