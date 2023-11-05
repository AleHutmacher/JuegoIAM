using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float maxTime;

    public TMP_Text textTime;

    [SerializeField]private float actualTime;

    [SerializeField] private bool finishedCountdown;
    // Start is called before the first frame update
    void Start()
    {
        actualTime = maxTime;
        finishedCountdown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (finishedCountdown != true)
        {
            updateTimer();
        }
    }

    void updateTimer()
    {
        if (actualTime > 0)
        {
            actualTime -= Time.deltaTime;
        }
        else
        {
            finishedCountdown = true;
        }

        DisplayTime(actualTime);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        textTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public bool getFinishedCountdown()
    {
        return finishedCountdown;
    }
}
