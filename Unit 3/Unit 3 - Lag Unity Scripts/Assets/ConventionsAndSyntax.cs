using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    void Start()
    {
        //this line is to tell me the x position of my objects

        /*Hello There!
         * General Kenobi!
         * */
        Debug.Log(transform.position.x);

        if(transform.position.y <=5f) 
        {
            Debug.Log("You are a bold one.");
        }
    }
}
