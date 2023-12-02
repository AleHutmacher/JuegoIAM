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
    [SerializeField] GameObject panelDefeat;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        actualTime = maxTime;
        finishedCountdown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!finishedCountdown)
        {
            updateTimer();
        }
        else
        {
            panelDefeat.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void updateTimer()
    {
        if (actualTime > 0)
        {
            //Si el tiempo del contador es mayor que 0, disminuye.
            actualTime -= Time.deltaTime;
        }
        else
        {
            //Al contrario, cuando ya no es mayor que 0, el bool que indica si el contador ya finalizó pasa a ser verdadero.
            finishedCountdown = true;
        }
        //Método que actualiza el tiempo del contador en formato minutos : segundos
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
