using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever_Collision_Script : MonoBehaviour
{
    public AudioSource audioclip;
    public bool hasStarted = false;
    public Collider leverCollider;

    void Start()
    {
        audioclip = GetComponent<AudioSource>();
        leverCollider = GetComponent<Collider>();
    }

    void Update()
    {
        if(audioclip.isPlaying)
        {
            hasStarted = true;
        }
    }

    void OnTriggerStay(Collider leverCollider)
    {
        // if the lever has not been pulled.
       if(hasStarted == false)
        {
            audioclip.Play();
        }   
    }

    void OnTriggerExit(Collider leverCollider)
    {
        audioclip.Stop();
        hasStarted = false;
    }
}
