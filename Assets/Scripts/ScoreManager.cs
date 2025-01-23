using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject ScoreBlueTextManager;
    public GameObject ScoreGreenTextManager;

    private int _scoreGreen;

    public int ScoreGreen
    {
        get { return _scoreGreen; }
        set { _scoreGreen = value; }
    }

    private int _scoreBlue;

    public int ScoreBlue
    {
        get { return _scoreBlue; }
        set { _scoreBlue = value; }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreBlueTextManager.GetComponent<TextMeshProUGUI>().text = ScoreBlue + "";
        ScoreGreenTextManager.GetComponent<TextMeshProUGUI>().text = ScoreGreen + "";
    }
}
