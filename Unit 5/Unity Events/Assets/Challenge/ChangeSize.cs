using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    
    void Start()
    {
        EventManager.ExampleEvent += IncreaseSize;
    }

    public void IncreaseSize() 
    {
        transform.localScale = new Vector3(4, 4, 4);
    }
    
    public void OnDisable() 
    {
        EventManager.ExampleEvent -= IncreaseSize;
    }
}
