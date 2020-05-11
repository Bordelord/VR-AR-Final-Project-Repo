using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesla_Button_Press_Script : MonoBehaviour
{
    public AudioSource audioclip;
    public Animation anim1;
    public Animation anim2;
    public Animation anim3;
    public Animation anim4;
    public Animation anim5;
    public Animation anim6;
    public Animation anim7;
    public bool hasStarted = false;
    public bool isColliding = false;
    public Collider buttonCollider;
    public bool on = false;
    public int oneTrick = 0;
    public GameObject bolt1;
    public GameObject bolt2;
    public GameObject bolt3;
    public GameObject bolt4;
    public string scriptName = "LightningBoltScript";

    void Start()
    {
        GameObject button = GameObject.FindWithTag("Button");
        bolt1 = GameObject.Find("Bolt 1");
        bolt2 = GameObject.Find("Bolt 2");
        bolt3 = GameObject.Find("Bolt 3");
        bolt4 = GameObject.Find("Bolt 4");

        (bolt1.GetComponent(scriptName) as MonoBehaviour).enabled = false;
        (bolt2.GetComponent(scriptName) as MonoBehaviour).enabled = false;
        (bolt3.GetComponent(scriptName) as MonoBehaviour).enabled = false;
        (bolt4.GetComponent(scriptName) as MonoBehaviour).enabled = false;

        GameObject gearbox1 = GameObject.Find("tGear1");
        GameObject gearbox2 = GameObject.Find("tGear2");
        GameObject gearbox3 = GameObject.Find("tGear3");
        GameObject gearbox4 = GameObject.Find("tGear4");
        GameObject gearbox5 = GameObject.Find("tGear5");
        GameObject gearbox6 = GameObject.Find("tSphere1");
        GameObject gearbox7 = GameObject.Find("tCylinder1");

        anim1 = gearbox1.GetComponent<Animation>();
        anim2 = gearbox2.GetComponent<Animation>();
        anim3 = gearbox3.GetComponent<Animation>();
        anim4 = gearbox4.GetComponent<Animation>();
        anim5 = gearbox5.GetComponent<Animation>();
        anim6 = gearbox6.GetComponent<Animation>();
        anim7 = gearbox7.GetComponent<Animation>();


        audioclip = GetComponent<AudioSource>();
        buttonCollider = button.GetComponent<Collider>();
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
            (bolt1.GetComponent(scriptName) as MonoBehaviour).enabled = true;
            (bolt2.GetComponent(scriptName) as MonoBehaviour).enabled = true;
            (bolt3.GetComponent(scriptName) as MonoBehaviour).enabled = true;
            (bolt4.GetComponent(scriptName) as MonoBehaviour).enabled = true;

            anim1.Play();
            anim2.Play();
            anim3.Play();
            anim4.Play();
            anim5.Play();
            anim6.Play();
            anim7.Play();
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

                (bolt1.GetComponent(scriptName) as MonoBehaviour).enabled = false;
                (bolt2.GetComponent(scriptName) as MonoBehaviour).enabled = false;
                (bolt3.GetComponent(scriptName) as MonoBehaviour).enabled = false;
                (bolt4.GetComponent(scriptName) as MonoBehaviour).enabled = false;

                anim1.Stop();
                anim2.Stop();
                anim3.Stop();
                anim4.Stop();
                anim5.Stop();
                anim6.Stop();
                anim7.Stop();

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