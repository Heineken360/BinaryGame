using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    private float timeStart = 60f;
    public Text timeCounter;

    void Start()
    {
        timeCounter.text = timeStart.ToString();
    }
    void Update()
    {
        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            timeCounter.text = Mathf.Round(timeStart).ToString();
        } else
        {
            Debug.Log("You Lose!");
            return;
        }
    }
}
