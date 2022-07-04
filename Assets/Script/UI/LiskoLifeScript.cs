using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class LiskoLifeScript : MonoBehaviour
{
    public static int liskoValue = 3;
    TextMeshProUGUI liskoLife;

    void Start()
    {
        liskoLife = GetComponent<TextMeshProUGUI>();
        liskoLife.text = "" + liskoValue;
      //  liskoValue = PlayerPrefs.GetInt("liskoAmount");
    }

    void Update()
    {
        if (liskoValue <= 0)
        {
            SceneManager.LoadScene(10);
            liskoValue = 3;
        } 
    }
}