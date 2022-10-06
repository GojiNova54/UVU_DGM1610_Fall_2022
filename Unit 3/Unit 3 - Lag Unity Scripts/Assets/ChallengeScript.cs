using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeScript : MonoBehaviour
{
    int missionTime = 24;
   
    void Start ()
    {
        Debug.Log("Entering Europa Exclusion Zone...");
        missionTime = DivideByTwo(missionTime);
        Debug.Log("Mission Time has been reduced to 12 hours.");
    }
    
    int DivideByTwo (int number)
    {
        int result;
        result = number / 2;
        return result;
    }
}
