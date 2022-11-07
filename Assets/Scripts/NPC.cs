using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameInfo gameInfo;
    private bool isColliding=false;
    public GameObject DialogoInicio;
    public GameObject DialogoFim;
    public AudioClip taskSound;

    void Update()
    {
        if (isColliding && Input.GetKeyDown(KeyCode.F) ) 
        {
            if(gameObject.name == "foxmage")
            {
                if(gameInfo.caughtFish==true) 
                {
                    gameInfo.deliverFish=true;
                    Debug.Log(gameInfo.deliverFish);
                    DialogoFim.SetActive(true);
                    ScoreTextScript.coinAmount+=1;
                    AudioSource.PlayClipAtPoint(taskSound, transform.position, 1);
                }

                else 
                {
                    gameInfo.requestFish = true;
                    Debug.Log(gameInfo.requestFish);
                    DialogoInicio.SetActive(true);
                }
            }

            if(gameObject.name == "AmeBeeSF")
            {
                if(gameInfo.fetchBall==true) 
                {
                    gameInfo.deliverBall=true;
                    Debug.Log(gameInfo.deliverBall);
                    DialogoFim.SetActive(true);
                    ScoreTextScript.coinAmount+=1;
                    AudioSource.PlayClipAtPoint(taskSound, transform.position, 1);
                }

                else 
                {
                    gameInfo.requestBall = true;
                    Debug.Log(gameInfo.requestBall);
                    DialogoInicio.SetActive(true);
                }
            }

            if(gameObject.name == "fox")
            {
                if(gameInfo.getBook==true) 
                {
                    gameInfo.deliverBook=true;
                    Debug.Log(gameInfo.deliverBook);
                    DialogoFim.SetActive(true);
                    ScoreTextScript.coinAmount+=1;
                    AudioSource.PlayClipAtPoint(taskSound, transform.position, 1);
                }

                else {
                    gameInfo.requestBook = true;
                    Debug.Log(gameInfo.requestBook);
                    DialogoInicio.SetActive(true);
                }
            }  

            if(gameObject.name == "TicketLady")
                {
                    DialogoInicio.SetActive(true);
                    AudioSource.PlayClipAtPoint(taskSound, transform.position, 1);
                }

            if(gameObject.name == "cat")
                {
                    AudioSource.PlayClipAtPoint(taskSound, transform.position, 1);
                    DialogoInicio.SetActive(true);
                    
                }
            
            if(gameObject.name == "anda")
                {
                    AudioSource.PlayClipAtPoint(taskSound, transform.position, 1);
                    DialogoInicio.SetActive(true);
                    
                }
            
        }
    }

//chegou perto do collectible ou saiu de perto do collectible?
    private void OnTriggerEnter(Collider other)
    {
        if  (other.tag=="Player")
        {
            isColliding=true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if  (other.tag=="Player")
        {
            isColliding=false;
        }
    }

}
