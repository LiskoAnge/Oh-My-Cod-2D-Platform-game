using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{

    public void OnMouseClick()
    {
        SceneManager.LoadScene(0);
    }
}
