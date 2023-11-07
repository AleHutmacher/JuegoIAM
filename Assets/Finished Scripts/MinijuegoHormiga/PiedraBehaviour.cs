using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiedraBehaviour : MonoBehaviour
{
    [SerializeField] GameObject box;
    [SerializeField] Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.getFinishedCountdown())
        {
            box.SetActive(false);
        }
    }
}
