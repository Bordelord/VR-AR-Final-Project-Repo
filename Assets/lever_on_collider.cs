using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever_on_collider : MonoBehaviour
{
    public AudioSource audioclip;
    public Collider leverCollider;
    
    void Start()
    {
        GameObject handle = GameObject.FindWithTag("Handle");
        audioclip = handle.GetComponent<AudioSource>();
        leverCollider = handle.GetComponent<Collider>();
    }

    void OnTriggerStay(Collider leverCollider)
    {
        if (!audioclip.isPlaying)
        { 
            audioclip.Play();
        }
    }
}
