using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameInfo gameInfo;
    private bool isColliding=false;
    public GameObject DialogoInicio;
    public GameObject DialogoFim;

    void Update()
    {
        if (isColliding && Input.GetMouseButtonUp(0)) 
        {
            if(gameObject.name == "foxmage")
            {
                if(gameInfo.caughtFish==true) 
                {
                    gameInfo.deliverFish=true;
                    gameInfo.money=gameInfo.money+1;
                    Debug.Log(gameInfo.deliverFish);
                    DialogoFim.SetActive(true);
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
                    gameInfo.money=gameInfo.money+1;
                    Debug.Log(gameInfo.deliverBall);
                    DialogoFim.SetActive(true);
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
                    gameInfo.money=gameInfo.money+1;
                    Debug.Log(gameInfo.deliverBook);
                    DialogoFim.SetActive(true);
                }

                else {
                    gameInfo.requestBook = true;
                    Debug.Log(gameInfo.requestBook);
                    DialogoInicio.SetActive(true);
                }
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
