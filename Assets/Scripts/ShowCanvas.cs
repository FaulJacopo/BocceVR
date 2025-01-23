using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCanvas : MonoBehaviour
{
    public Canvas canvas;

    public void showHideCanvas()
    {
        canvas.gameObject.SetActive(!canvas.gameObject.active);
    }
}
