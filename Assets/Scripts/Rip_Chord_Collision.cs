using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rip_Chord_Collision : MonoBehaviour
{

    public Animation anim1;
    public Animation anim2;
    public AudioSource audioclip;
    public Collider ChordCollider;

    public bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject pist1 = GameObject.FindWithTag("piston1");
        GameObject pist2 = GameObject.FindWithTag("piston2");
        GameObject collisionD = GameObject.FindWithTag("collision block");
        anim1 = pist1.GetComponent<Animation>();
        anim2 = pist2.GetComponent<Animation>();
        ChordCollider = collisionD.GetComponent<Collider>();
        audioclip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider ChordCollider)
    {
        // if the button has not been pressed.
        if (hasStarted == false)
        {
            anim1.Play();
            anim2.Play();
            audioclip.Play();
            hasStarted = true;
        }
    }

    void OnTriggerExit(Collider ChordCollider)
    {
        stopAnimation();
        hasStarted = false;
    }

    IEnumerator stopAnimation()
    {
        if (hasStarted)
        {
            yield return new WaitForSeconds(1.0f);
            anim1.Stop();
            anim2.Stop();
            audioclip.Stop();
        }
    }

}
