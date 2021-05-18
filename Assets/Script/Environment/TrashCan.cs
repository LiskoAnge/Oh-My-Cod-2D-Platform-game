using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{


    public GameObject[] cans;
    public Transform canPos;
    int randomCan;

    Animator anim;
    public AudioSource trashCan;

    void Start()
    {

        GetComponent<BoxCollider2D>().enabled = true;
        anim = GetComponent<Animator>();

    }

    void Update()
    {

    }




    

    private void OnTriggerEnter2D(Collider2D other)
    {


        

        



        if (Input.GetKey(KeyCode.UpArrow) && other.gameObject.tag.Equals("tPlayer"))
        {
         
            StartCoroutine("Can");



        }

        

   

    }






    public IEnumerator Can()
    {

        GetComponent<BoxCollider2D>().enabled = false;
        trashCan.Play();
        anim.SetTrigger("openTrash");


        yield return new WaitForSeconds(0f);
        randomCan = Random.Range(0, cans.Length);
        Instantiate(cans[randomCan], canPos.position, canPos.rotation);
    }

    

}