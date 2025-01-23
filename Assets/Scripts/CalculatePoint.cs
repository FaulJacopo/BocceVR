using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class CalculatePoint : MonoBehaviour
{
    private GameObject[] bocceBlue;
    private GameObject[] bocceGreen;
    private GameObject pallino;
    public ScoreManager scoreManager;

    void Start()
    {
        bocceBlue = GameObject.FindGameObjectsWithTag("Blue");
        bocceGreen = GameObject.FindGameObjectsWithTag("Green");
        pallino = GameObject.FindGameObjectWithTag("Pallino");
    }

    public void CalculateFinalPoints()
    {
        bool pointIsBlue = false;
        int totalPoints = 0;

        List<float> distanceBluFromPallino = new List<float>();
        List<float> distanceGreenFromPallino = new List<float>();

        for (int i = 0; i < bocceBlue.Length; i++)
        {
            distanceBluFromPallino.Add(Vector3.Distance(pallino.transform.position, bocceBlue[i].transform.position));
            distanceGreenFromPallino.Add(Vector3.Distance(pallino.transform.position, bocceGreen[i].transform.position));
        }

        float minDistanceBlu = distanceBluFromPallino.Min();
        float minDistanceGreen = distanceGreenFromPallino.Min();

        pointIsBlue = (minDistanceBlu < minDistanceGreen);

        for (int i = 0; i < distanceBluFromPallino.Count; i++)
        {
            if (pointIsBlue)
            {
                if (distanceBluFromPallino[i] < minDistanceGreen)
                    totalPoints++;
            } 
            else
            {
                if (distanceGreenFromPallino[i] < minDistanceBlu)
                    totalPoints++;
            }
        }

        if (pointIsBlue)
            scoreManager.ScoreBlue += totalPoints;
        else
            scoreManager.ScoreGreen += totalPoints;

        GetComponent<AudioSource>().Play();
    }
}
