using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Game Info")]

public class GameInfo : ScriptableObject
{
    //__________Request Things______________//
        public bool requestFish = false;
        public bool requestBook = false;
        public bool requestBall = false;

    //__________Player Gets Things___________//
        public bool caughtFish = false;
        public bool getBook = false;
        public bool fetchBall = false;

    //__________Player Delivers Things__________//
        public bool deliverFish = false;
        public bool deliverBook = false;
        public bool deliverBall = false;
        
    //----------MONEY -----------//
        public int money=0; 
}
