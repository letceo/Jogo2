using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public GameInfo gameInfo;
    private bool isColliding=false;

//se estiver perto do collectible e interagir faz coisa
    void Update()
    {
        if (isColliding && Input.GetKeyDown(KeyCode.F)) 
        {
            if(gameObject.name == "fish" && gameInfo.requestFish == true)
            {
                gameInfo.caughtFish = true;
                Debug.Log(gameInfo.caughtFish);
                Destroy(gameObject);
            }

            if(gameObject.name == "book2" && gameInfo.requestBook == true)
            {
                gameInfo.getBook = true;
                Debug.Log(gameInfo.getBook);
                Destroy(gameObject);
            }

            if(gameObject.name == "football" && gameInfo.requestBook == true)
            {
                gameInfo.fetchBall = true;
                Debug.Log(gameInfo.fetchBall);
                Destroy(gameObject);
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



//adicionar variavel publica de gameinfo 
//alterar destroy para o if(gameobject.name = "fish") gameinfo.caughtFish = true; e faço isto para os diferentes objetos no game info. Criar outro script com outro nome(NPC) onde faço a cena para dar a quest e gameinfo.caughtFish que é a mesma do outro, verifica se apanhoue tem o contador 
//game info - wallet= wallet+1