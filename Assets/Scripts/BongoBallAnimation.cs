using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BongoBallAnimation : MonoBehaviour
{
    public Animation anim;
    public Collider ballCollider;
    // Start is called before the first frame update
    void Start()
    {
        GameObject ball = GameObject.FindWithTag("Ball");
        anim = ball.GetComponent<Animation>();
        ballCollider = ball.GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider ballCollider)
    {
        anim.Play();
    }
}
