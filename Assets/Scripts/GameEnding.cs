using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public GameInfo gameInfo;
    public GameObject player;
    public GameObject boat;

    bool m_IsPlayerAtExit;

    void OnTriggerEnter (Collider boat)
    {
        if (boat.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }

    void Update ()
    {
        if(gameInfo.deliverFish==true && gameInfo.deliverBall==true && gameInfo.deliverBook==true)
        {
            gameInfo.missionAccomplished=true;
        }

        if(m_IsPlayerAtExit && gameInfo.missionAccomplished==true)
        {
            Debug.Log("Pronto a partir");
            EndLevel ();
        }

        if(m_IsPlayerAtExit && gameInfo.missionAccomplished==false)
        {
            Debug.Log("Nao completou tasks");
        }
    }

    void EndLevel ()
    {
        SceneManager.LoadScene (5);
    }
}

