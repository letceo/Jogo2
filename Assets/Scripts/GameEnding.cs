using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public GameInfo gameInfo;
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    public GameObject boat;

    bool m_IsPlayerAtExit;
    float m_Timer;

    void OnTriggerEnter (Collider boat)
    {
        if (boat.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }

    void Update ()
    {
        if(m_IsPlayerAtExit && gameInfo.deliverFish==true && gameInfo.deliverBall==true && gameInfo.deliverBook==true)
        {
            EndLevel ();
        }
        else
        {
            Debug.Log("Não completou tasks");
        }
    }

    void EndLevel ()
    {
        m_Timer += Time.deltaTime;
        exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;
        if(m_Timer > fadeDuration)
        {
            Application.Quit();
        }
    }
}
