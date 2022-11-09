using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public GameInfo gameInfo;
    public GameObject player;
    public GameObject boat;
    public GameObject DialogoInicio;
    public GameObject DialogoEndGame;
    public AudioClip taskSound;

    bool m_IsPlayerAtExit;

    void Update ()
    {
        if(gameInfo.deliverFish==true && gameInfo.deliverBall==true && gameInfo.deliverBook==true)
        {
            AudioSource.PlayClipAtPoint(taskSound, transform.position, 1);
            gameInfo.missionAccomplished=true;
            DialogoEndGame.SetActive(true);

        }

        if(m_IsPlayerAtExit && gameInfo.missionAccomplished==true)
        {
            Debug.Log("Pronto a partir");
            EndLevel ();
        }
    }

    void OnTriggerEnter (Collider boat)
    {
        if (boat.gameObject == player && gameInfo.missionAccomplished==false)
        {
            DialogoInicio.SetActive(true);
            Debug.Log("Nao completou tasks");
            m_IsPlayerAtExit=false;
        }
        else 
            if(boat.gameObject == player && gameInfo.missionAccomplished==true)
            {
                m_IsPlayerAtExit=true;
            }
    }

    void EndLevel ()
    {
        SceneManager.LoadScene (5);
    }
}

