using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeScript : MonoBehaviour
{
    int missionTime = 24;
    int numEnemies = 10;
    void Start()
    {
        Debug.Log("Entering Europa Exclusion Zone...");
        missionTime = DivideByTwo(missionTime);
        Debug.Log("Mission Time has been reduced to 12 hours.");

        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Number of unknown entities have appeared on sonar: " + i);
        }
    }

    int DivideByTwo(int number)
    {
        int result;
        result = number / 2;
        return result;
    }

    float subDepth = 800;
    float decreasedDepthLimit = 600;
    float nominalDepthLimit = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            DepthTest();

        subDepth -= Time.deltaTime * 40;
    }

    void DepthTest()
    {
        if (subDepth > decreasedDepthLimit)
        {
            print("Warning, sub at critical depth limit.");
        }

        else if (subDepth < nominalDepthLimit)
        {
            print("Warning, approaching unbreachable surface.");
        }

        else
        {
            print("Submarine is at nominal depth.");
        }
    }

}

    
