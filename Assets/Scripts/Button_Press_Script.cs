using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Press_Script : MonoBehaviour
{
    public AudioSource audioclip;
    public bool hasStarted = false;
    public bool isColliding = false;
    public Collider buttonCollider;
    public bool on = false;
    public int oneTrick = 0;


    void Start()
    {
        GameObject button = GameObject.FindWithTag("Button");

        audioclip = GetComponent<AudioSource>();
        buttonCollider = button.GetComponent<Collider>();
        //bool isOn = false;
        //bool isOff = true;
    }

    void Update()
    {
        if (audioclip.isPlaying)
        {
            hasStarted = true;
        }
    }

    void OnTriggerEnter(Collider buttonCollider)
    {
        Debug.Log("Colliding!");
        // button pressed!
        if (hasStarted == false)
        {
            audioclip.Play();
            on = true;
        }
        else
        {
            on = false;
        }
    }

    void OnTriggerExit(Collider buttonCollider)
    {
        if (hasStarted)
        {
            if (oneTrick == 1)
            {
                audioclip.Stop();
                hasStarted = false;
                on = false;
                oneTrick = 0;
            }
            else
            {
                oneTrick = 1;
            }
        }
        //onOffToggle();
    }

    
}