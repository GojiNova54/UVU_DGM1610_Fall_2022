using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnDestroy : MonoBehaviour
{
    public AudioClip destroySoundEffect;
    void DestroyObject() 
    {
        AudioSource.PlayClipAtPoint(destroySoundEffect, transform.position);
        Destroy(gameObject);
    }
}
