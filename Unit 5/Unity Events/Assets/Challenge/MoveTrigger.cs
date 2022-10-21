using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrigger : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        EventManager.StartMoveEvent();
    }
}
