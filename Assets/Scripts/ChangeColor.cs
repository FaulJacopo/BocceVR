using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    public void ColorChange()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void ColorChangeEnd()
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
