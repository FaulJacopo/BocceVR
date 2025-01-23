using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnOnOffLight : MonoBehaviour
{
    [SerializeField]
    GameObject[] lights;

    public void changeIntensity()
    {
        float intensity = GetComponent<Slider>().value;

        foreach (GameObject go in lights)
        {
            Light light = go.GetComponent<Light>();
            light.intensity = intensity;
        }
    }
}
