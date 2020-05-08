using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_collide_animation : MonoBehaviour
{
    public Animation anim;
    
    public Collider RhandCollider;
    public Collider LhandCollider;

    public bool hasStarted = false;

    void Start()
    {
        Time.timeScale = 1.0f;
        anim = GetComponent<Animation>();
        RhandCollider = GetComponent<Collider>();
        LhandCollider = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider buttonCollider)
    {
        // if the button has not been pressed.
        if (hasStarted == false)
        {
            anim.Play();
            hasStarted = true;
        }
    }

    void OnTriggerExit(Collider buttonCollider)
    {
        stopAnimation();
        hasStarted = false;
    }

    IEnumerator stopAnimation()
    {
        if (hasStarted)
        {
            yield return new WaitForSeconds(1.0f);
            anim.Stop();
        }
    }
}
