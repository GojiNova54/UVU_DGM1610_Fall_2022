using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action ExampleEvent;

    public static event Action MoveEvent;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        
        {
            ExampleEvent.Invoke();
        }
    }

    public static void StartMoveEvent() 
    {
        MoveEvent.Invoke();
    }
}
