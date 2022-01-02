using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Point : MonoBehaviour
{
    [Header("Point")]
    private float startingPoint = 0;

    public float currentPoint { get; private set; }
    [SerializeField] private Text pointText;
    private void Awake()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1){
            startingPoint = 0;
        }
        else
        {
            startingPoint = PlayerPrefs.GetFloat("Points", currentPoint);
            currentPoint = startingPoint;
        }
        pointText.text = currentPoint.ToString();
    }
    public void AddPoint(float _value)
    {
        currentPoint += _value;
        pointText.text = currentPoint.ToString();
        PlayerPrefs.SetFloat("Points", currentPoint);
    }
    public float getCurrentPoint()
    {
        return currentPoint;
    }
}
