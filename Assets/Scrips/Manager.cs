using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private Text pointsText;

    float totalPoints;

    bool hasUpgrade;
    [SerializeField] private int pasivePointGain;
    [SerializeField] private int pointForUpgrade;

    public void AddPoints()
    {
        totalPoints++;
        pointsText.text = totalPoints.ToString("0");
    }

    public void PointsUpgrade()
    {
        if (!hasUpgrade && totalPoints >= pointForUpgrade)
        {
            totalPoints -= pointForUpgrade;
            hasUpgrade = true;
        }
    }

    private void Update()
    {
        if (hasUpgrade)
        {
            totalPoints += pasivePointGain * Time.deltaTime;
            pointsText.text = totalPoints.ToString("0");

        }
    }
}
