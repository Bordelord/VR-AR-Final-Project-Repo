using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boiler_Rise : MonoBehaviour
{
    public AudioSource p;
    public AudioSource b;
    public AudioSource t;
    public AudioSource h;
    public Animation anim;
    public bool one = false;
    public bool two = false;
    public bool three = false;
    public bool four = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject piston = GameObject.FindWithTag("Trigger");
        GameObject bongo = GameObject.FindWithTag("Handle");
        GameObject tesla = GameObject.FindWithTag("Trigger2");
        GameObject heatcoil = GameObject.FindWithTag("Trigger3");

        p = piston.GetComponent<AudioSource>();
        b = bongo.GetComponent<AudioSource>();
        t = tesla.GetComponent<AudioSource>();
        h = heatcoil.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(allActive())
        {
            anim.Play();
        }
    }

    bool allActive()
    {

        if(p.isPlaying == true)
        {
            one = true;
        }

        if (b.isPlaying == true)
        {
            two = true;
        }

        if (t.isPlaying == true)
        {
            three = true;
        }

        if (h.isPlaying == true)
        {
            four = true;
        }

        if(one == true && two == true && three == true && four == true)
        {
            return true;
        }else
        {
            return false;
        }
    }
}
