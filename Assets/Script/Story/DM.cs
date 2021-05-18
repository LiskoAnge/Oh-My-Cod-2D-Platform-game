using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DM : MonoBehaviour
{


   // public Text textName;
    public Text chatText;
    public GameObject OwnerImage, LiskoImage;
    public Animator anim;
    private Queue<string> sentences;



    void Start()
    {
        sentences = new Queue<string>();

        OwnerImage.gameObject.SetActive(true);
        LiskoImage.gameObject.SetActive(false);
    }







    public void showNextPhrase()
    {
        OwnerImage.gameObject.SetActive(true);

        if (sentences.Count <= 2)
        {
            OwnerImage.gameObject.SetActive(false);
            LiskoImage.gameObject.SetActive(true);

        }

        if (sentences.Count == 0)
        {

            EndOfDialogue();
            return;
        }

        string sentence = sentences.Dequeue();

        StopAllCoroutines();   //stop current anim to start a new one
        //chatText.text = sentence;

        StartCoroutine(LetterByLetter(sentence));

     
    }


    

    IEnumerator LetterByLetter (string sentence)
    {
        chatText.text = "";
        foreach (char letter in sentence.ToCharArray())         //to show one letter by one when dialogues 
        {
            chatText.text += letter;
            yield return null;
        }
    }




    public void EndOfDialogue()
    {
        anim.SetBool("chatOpen", false);
        Debug.Log("End of conversation!!");
        Time.timeScale = 1;

    }



    public void StartDialogue(Dialogue dialogue)
    {

        anim.SetBool("chatOpen", true);

       // textName.text = dialogue.name;

        sentences.Clear();



        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }


        showNextPhrase();




    }


    /*
    private void OnCollisionEnter2D(Collision2D colli)
    {



        if (colli.gameObject.tag.Equals("tDialogue"))
        {

            StartDialogue(Dialogue dialogue);





        }

    }
    */
    
}
