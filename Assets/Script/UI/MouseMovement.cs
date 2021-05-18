using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public GameObject fishAndChipsIcon;
    public GameObject fishAndChipsIcon2;


    private void Start()
    {
        fishAndChipsIcon.SetActive(false);
        fishAndChipsIcon2.SetActive(false);

    }



    public void onMouseHoverContinue()
    {
        fishAndChipsIcon.SetActive(true);
        fishAndChipsIcon2.SetActive(false);
    }

    public void onMouseHoverMenu()
    {
        fishAndChipsIcon.SetActive(false);
        fishAndChipsIcon2.SetActive(true);
    }

    public void OnMouseExitContinue()
    {
        fishAndChipsIcon.SetActive(false);


    }

    public void OnMouseExitMenu()
    {
   
        fishAndChipsIcon2.SetActive(false);

    }


}
