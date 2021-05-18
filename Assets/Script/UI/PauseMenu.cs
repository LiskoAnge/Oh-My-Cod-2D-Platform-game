using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    //Save saveGameData;
    private bool pauseMenu;

    private bool tempTest;


    public GameObject pausePanel;
    public GameObject controlsPanel;


    // public GameObject pauseMenuPanel;

    private void Awake()
    {
        controlsPanel.SetActive(false);
        pausePanel.SetActive(false);
    }




    private void Update()
    {


        if (Input.GetButtonDown("OpenHint"))
        {

           pauseMenu = !pauseMenu;
            // Time.timeScale = 0;   //stop game

        }

        if (pauseMenu)
        {
             Time.timeScale = 0;   //stop game
            pausePanel.SetActive(true);

        }
        else
        {
             Time.timeScale = 1;   //continue game
            controlsPanel.SetActive(false);
            pausePanel.SetActive(false);
        }


    }

  



    // if(Input.GetKeyDown(KeyCode.Escape)){




}
