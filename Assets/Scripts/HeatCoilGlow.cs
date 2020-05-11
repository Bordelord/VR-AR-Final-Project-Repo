using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatCoilGlow : MonoBehaviour
{
    public GameObject switchH;
    public string scriptName = "Button_Press_Script";
    public Material HeatCoilOff;
    public Material HeatCoilOn;
    float duration = 2.0f;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        switchH = GameObject.Find("SwitchH");
        rend = GetComponent<Renderer>();
        rend.material = HeatCoilOff;
    }

    // Update is called once per frame
    void Update()
    {
        if ((switchH.GetComponent(scriptName) as MonoBehaviour).enabled == true)
        {
            rend.material = HeatCoilOn;
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            rend.material.Lerp(HeatCoilOff, HeatCoilOn, lerp);
        }
    }
}
