using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    Animator ani;
    //public AudioSource whistle;

    void Start()
    {
        ani = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag.Equals("tPlayer"))
        {
            //whistle.Play();
            ani.SetTrigger("finishLine");
        }
    }
}
