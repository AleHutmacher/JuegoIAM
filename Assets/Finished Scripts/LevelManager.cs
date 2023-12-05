using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public waypointCheck wpA, wpB;

    PlayerBehaviour player;

    Timer timer;

    public GameObject panelRevisar;
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("TimerManager").GetComponent<Timer>();
        player = GameObject.Find("Player").GetComponent<PlayerBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    bool checkpointsSuccesfull()
    {
        return wpA.GetCheckedPosition() == true && wpB.GetCheckedPosition() == true;
    }

    public void intentarLevel()
    {
        if (checkpointsSuccesfull() == true)
        {
            activateFinal();
        }
        else
        {
            timer.StopCountdown();
            panelRevisar.SetActive(true);
        }
    }

    void activateFinal()
    {
        player.StartMovement();
    }
}
