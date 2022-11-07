using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextScript : MonoBehaviour
{
    public TMP_Text text;
    public static int coinAmount;

    // Start is called before the first frame update
    void Start()
    {
        text=GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text=coinAmount.ToString();
    }
}