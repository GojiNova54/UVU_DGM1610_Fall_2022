using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color newColor;
    void Start()
    {
        EventManager.ExampleEvent += SetNewColor;
    }

   public void SetNewColor() 
    {
        GetComponent<SpriteRenderer>().color = newColor;
    }

    public void OnDisable()
    {
        EventManager.ExampleEvent -= SetNewColor;
    }
}
