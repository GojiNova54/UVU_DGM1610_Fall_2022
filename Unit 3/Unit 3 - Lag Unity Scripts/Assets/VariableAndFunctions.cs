using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableAndFunctions : MonoBehaviour
{
    int myInt = 10;


    void Start()
    {
        myInt = MultiplyByTen(myInt);
        Debug.Log(myInt);
    }


    int MultiplyByTen(int number)
    {
        int result;
        result = number * 10;
        return result;
    }
}
