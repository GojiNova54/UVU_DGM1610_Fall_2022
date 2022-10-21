using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public Transform movePoint;
    public bool move = false;
    public void Start()
    {
        EventManager.MoveEvent += MoveCapsule;
    }

  
    void Update()
    {
        if (move == true)
            transform.position = Vector2.MoveTowards(transform.position, movePoint.position, 5 * Time.deltaTime);
    }

    public void MoveCapsule()
    {
        move = true;
    }

    public void OnDisable()
    {
        EventManager.MoveEvent -= MoveCapsule;
    }
}
