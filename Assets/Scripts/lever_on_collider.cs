using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever_on_collider : MonoBehaviour
{
    public AudioSource audioclip;
    public Collider leverCollider;
    public GameObject ball;
    public Rigidbody rb;
    void Start()
    {
        GameObject handle = GameObject.FindWithTag("Handle");
        audioclip = handle.GetComponent<AudioSource>();
        leverCollider = handle.GetComponent<Collider>();
        GameObject ball = GameObject.FindWithTag("Ball");
        rb = ball.GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider leverCollider)
    {
        if (!audioclip.isPlaying)
        { 
            audioclip.Play();
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
