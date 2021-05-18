using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddLitter : MonoBehaviour
{

    Animator ani;

    Rigidbody2D rgbd;             

    public AudioSource litterSound;

    Collider2D litterCollider;

    private float litterSpeed = 0.3f;

    private void Start()
    {
        ani = GetComponent<Animator>();
        litterCollider = GetComponent<Collider2D>();
        rgbd = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag.Equals("tPlayer"))
        {

            //Debug.Log("Coin picked up");

            litterCollider.enabled = !litterCollider.enabled;
            Debug.Log("Liiter Collider.enabled = " + litterCollider.enabled);
            LitterScript.litterValue += 1;
            ani.SetTrigger("litterCollected");
            litterSound.Play();
            rgbd.velocity = new Vector2(0f, litterSpeed);
            Destroy(gameObject, 1f);
        }

    }





}

