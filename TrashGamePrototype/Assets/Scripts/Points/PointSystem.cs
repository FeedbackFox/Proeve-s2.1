using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// In this script you will find the entire points system for this game
/// </summary>
public class PointSystem : MonoBehaviour
{
    //Points value
    public int _obtainedPoints;
    public Text PointsText;

    private void Awake()
    {
        _obtainedPoints = 1000;
        PointsText.text = "Points: " + _obtainedPoints.ToString();
    }

    //Adds the given amount of points to the total(_obtainedPoints)
    public void AddPoints(int points)
    {
        _obtainedPoints += points;
        PointsText.text = "Points: " + _obtainedPoints.ToString();
    }

    //Removes the given amount of points from the total(_obtainedPoints)
    public void RemovePoints(int points)
    {
        _obtainedPoints -= points;
        Debug.Log("Removed: " + points + " points");
        Debug.Log(_obtainedPoints);
        PointsText.text = "Points: " + _obtainedPoints.ToString();
    }
}